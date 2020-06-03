import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Comment } from './comment';
import { delay } from 'rxjs/operators';

@Injectable({
    providedIn: 'root'
})
export class CommentService {
    private url = 'https://localhost:44394/api/comments/postId';

    constructor(private httpClient: HttpClient) {
    }

    getComments(id) {
        return this.httpClient.get<Comment[]>(this.url + '/' + id)
            .pipe(delay(300));
    }
}
