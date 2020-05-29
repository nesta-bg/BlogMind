import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Post } from './post';

@Injectable({
    providedIn: 'root'
})
export class PostService {
    private url = 'https://localhost:44394/api/posts';

    constructor(private httpClient: HttpClient) {
    }

    getPosts() {
        return this.httpClient.get<Post[]>(this.url);
    }
}
