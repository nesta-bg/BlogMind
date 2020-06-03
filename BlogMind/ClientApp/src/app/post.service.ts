import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Post } from './post';
import { delay } from 'rxjs/operators';


@Injectable({
    providedIn: 'root'
})
export class PostService {
    private url = 'https://localhost:44394/api/posts';

    constructor(private httpClient: HttpClient) {
    }

    getPosts() {
        return this.httpClient.get<Post[]>(this.url)
            .pipe(delay(300));
    }

    getPostsByUser(userId) {
        return this.httpClient.get<Post[]>(this.url + '/' + userId)
            .pipe(delay(300));
    }
}
