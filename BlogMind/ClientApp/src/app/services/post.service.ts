import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Post } from '../post';
import { delay } from 'rxjs/operators';
import { environment } from 'src/environments/environment';

@Injectable({
    providedIn: 'root'
})
export class PostService {
    private readonly myAppUrl: string;
    private readonly postsEndpoint: string;

    constructor(private httpClient: HttpClient) {
        this.myAppUrl = environment.appUrl;
        this.postsEndpoint = 'api/posts';
    }

    getPosts() {
        return this.httpClient.get<Post[]>(this.myAppUrl + this.postsEndpoint)
            .pipe(delay(300));
    }

    getPostsByUser(userId) {
        return this.httpClient.get<Post[]>(this.myAppUrl + this.postsEndpoint + '/' + userId)
            .pipe(delay(300));
    }
}
