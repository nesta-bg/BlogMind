import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Comment } from '../comment';
import { delay } from 'rxjs/operators';
import { environment } from 'src/environments/environment';

@Injectable({
    providedIn: 'root'
})
export class CommentService {
    private readonly myAppUrl: string;
    private readonly commentsEndpoint: string;

    constructor(private httpClient: HttpClient) {
        this.myAppUrl = environment.appUrl;
        this.commentsEndpoint = 'api/comments';
    }

    getComments(id) {
        return this.httpClient.get<Comment[]>(this.myAppUrl + this.commentsEndpoint + '/postId/' + id)
            .pipe(delay(300));
    }
}
