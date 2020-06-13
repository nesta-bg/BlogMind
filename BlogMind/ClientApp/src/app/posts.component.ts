import { Component, OnInit } from '@angular/core';
import { Post } from './post';
import { PostService } from './post.service';
import { CommentService } from './comment.service';
import { Comment } from './comment';
import { UserService } from './user.service';
import { FavoriteService } from './favorite.service';
import { User } from './user';
import * as _ from 'underscore';
import { LikeService } from './like.service';
import { VoteService } from './vote.service';
import { forkJoin } from 'rxjs';

@Component({
  templateUrl: './posts.component.html',
  styleUrls: ['./posts.component.css']
})
export class PostsComponent implements OnInit {
  posts: Post[] = [];
  pageSize = 5;
  pagedPosts: Post[] = [];
  postsLoading = true;
  currentPost: Post = null;
  userImgUrl = 'https://localhost:44394/uploads/';
  comments: Comment[] = [];
  commentsLoading;
  users: User[] = [];
  loggedInUser = null;
  isPostUserFavorite;
  userVote = 0;
  voteCount = 0;

  onVote($event) {
    console.log($event);
  }

  constructor(
    private postService: PostService,
    private commentService: CommentService,
    private userService: UserService,
    private favoriteService: FavoriteService,
    private likeService: LikeService,
    private voteService: VoteService) { }

  ngOnInit() {
    if (localStorage.getItem('token')) {
      this.getLoggedUser();
    }
    this.loadUsers();
    this.loadPosts();
  }

  getLoggedUser() {
    this.userService.getLoggedInUser()
      .subscribe(user => {
        this.loggedInUser = user;
      });
  }

  loadUsers() {
    this.userService.getUsers()
      .subscribe(
        users => this.users = users
      );
  }

  loadPosts() {
    this.postService.getPosts()
      .subscribe(
        posts => { this.posts = posts,
        this.pagedPosts = _.take(this.posts, this.pageSize);
        },
        () => null,
        () => { this.postsLoading = false; }
      );
  }

  reloadPosts(userId) {
    this.postsLoading = true;
    this.currentPost = null;

    if (!userId) {
      this.loadPosts();
    } else {
      this.loadPostsByUser(userId);
    }
  }

  loadPostsByUser(userId) {
    this.posts = [];

    this.postService.getPostsByUser(userId)
      .subscribe(
        posts => {
          this.posts = posts;
          this.pagedPosts = _.take(this.posts, this.pageSize);
        },
        () => null,
        () => { this.postsLoading = false; }
      );
  }

  onPageChanged(page) {
    let startIndex = (page - 1) * this.pageSize;
    this.pagedPosts = _.take(_.rest(this.posts, startIndex), this.pageSize);
  }

  select(post) {
    this.currentPost = post;

    if (this.loggedInUser != null) {
      this.favoriteService.isPostUserFavorite(this.currentPost.id, this.loggedInUser.id)
        .subscribe(isFavorite => this.isPostUserFavorite = isFavorite);
    }

    this.commentsLoading = true;

    this.commentService.getComments(this.currentPost.id)
      .subscribe(
        comments => this.comments = comments,
        () => null,
        () => { this.commentsLoading = false; }
      );

    forkJoin(this.voteService.getUserVote(this.currentPost.id, this.loggedInUser.id), this.voteService.getVoteCountExcludingUser(this.currentPost.id, this.loggedInUser.id))
      .subscribe({
        next: (res: any) => {
          this.userVote = res[0],
          this.voteCount = res[1];
        },
        error: (err: any) => {
          console.log(err);
        }
      });

    // this is how it would looks like with client side logic
    // userVote(post: Post) {
    //   const data = post.votes.find(ob => ob.userId === this.loggedInUser.id);
    //   if (data) {
    //     return data.mark;
    //   } else {
    //     return 0;
    //   }
    // }

    // voteCount(post: Post) {
    //   return  post.votes.filter(ob => ob.mark).reduce((sum, current) => sum + current.mark, 0);
    // }

  }

  onFavoriteChange($event) {
    if ($event.newValue == true) {
      this.favoriteService.makePostUserFavorite(this.currentPost.id, this.loggedInUser.id)
        .subscribe(x => console.log(x));
      this.isPostUserFavorite = true;
    } else {
      this.favoriteService.removePostUserFavorite(this.currentPost.id, this.loggedInUser.id)
        .subscribe(x => console.log(x));
      this.isPostUserFavorite = false;
    }
  }

  isUserLikeComment(comment: Comment) {
    let data = comment.likes.find(ob => ob.appUserId == this.loggedInUser.id);
    if (data) {
      return true;
    } else {
      return false;
    }
  }

  onLikeChange($event) {
    if ($event.newValue == 1) {
      this.likeService.addLike($event.commentId, this.loggedInUser.id)
        .subscribe(x => console.log(x));
    } else if ($event.newValue == -1) {
      this.likeService.deleteLike($event.commentId, this.loggedInUser.id)
        .subscribe(x => console.log(x));
    }
  }

}

