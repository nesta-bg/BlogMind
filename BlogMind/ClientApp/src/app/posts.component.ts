import { Component, OnInit } from '@angular/core';
import { Post } from './post';
import { PostService } from './post.service';
import { CommentService } from './comment.service';
import { Comment } from './comment';

@Component({
  templateUrl: './posts.component.html',
  styleUrls: ['./posts.component.css']
})
export class PostsComponent implements OnInit {
  posts: Post[] = [];
  postsLoading = true;
  currentPost: Post = null;
  userImgUrl = 'https://localhost:44394/uploads/';
  comments: Comment[] = [];
  commentsLoading;

  constructor(private postService: PostService, private commentService: CommentService) { }

  ngOnInit() {
    this.postService.getPosts()
      .subscribe(
        posts => this.posts = posts,
        () => null,
        () => { this.postsLoading = false; }
      );
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

