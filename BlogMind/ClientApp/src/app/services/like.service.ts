import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class LikeService {
  private readonly myAppUrl: string;
  private readonly likesEndpoint: string;

  constructor(private httpClient: HttpClient) {
    this.myAppUrl = environment.appUrl;
    this.likesEndpoint = 'api/likes';
  }

  addLike(commentId, userId) {
    return this.httpClient.post(this.myAppUrl + this.likesEndpoint + '/' + commentId + '/' + userId, commentId, userId);
  }

  deleteLike(commentId, userId) {
    return this.httpClient.delete(this.myAppUrl + this.likesEndpoint + '/' + commentId + '/' + userId);
  }

}
