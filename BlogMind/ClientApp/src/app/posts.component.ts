import { Component, OnInit } from '@angular/core';
import { Post } from './post';
import { PostService } from './post.service';
import { CommentService } from './comment.service';
import { Comment } from './comment';
import { UserService } from './user.service';
import { User } from './user';
import * as _ from 'underscore';

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

  constructor(
    private postService: PostService,
    private commentService: CommentService,
    private userService: UserService) { }

  ngOnInit() {
    this.loadUsers();
    this.loadPosts();
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

    this.commentsLoading = true;

    this.commentService.getComments(this.currentPost.id)
      .subscribe(
        comments => this.comments = comments,
        () => null,
        () => { this.commentsLoading = false; }
      );
  }
}

