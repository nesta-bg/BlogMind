import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LikeService {
  private url = 'https://localhost:44394/api/likes';

  constructor(private httpClient: HttpClient) { }

  addLike(commentId, userId) {
    return this.httpClient.post(this.url + '/' + commentId + '/' + userId, commentId, userId);
  }

  deleteLike(commentId, userId) {
    return this.httpClient.delete(this.url + '/' + commentId + '/' + userId);
  }

}
