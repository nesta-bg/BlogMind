import { Component, OnInit } from '@angular/core';
import { Post } from './post';
import { PostService } from './post.service';

@Component({
  templateUrl: './posts.component.html',
  styleUrls: ['./posts.component.css']
})
export class PostsComponent implements OnInit {
  posts: Post[] = [];
  isLoading = true;
  currentPost: Post = null;
  userImgUrl = 'https://localhost:44394/uploads/';

  constructor(private postService: PostService) { }

  ngOnInit() {
    this.postService.getPosts()
      .subscribe(
        posts => this.posts = posts,
        () => null,
        () => { this.isLoading = false; }
      );
  }

  select(post) {
    this.currentPost = post;
  }
}

