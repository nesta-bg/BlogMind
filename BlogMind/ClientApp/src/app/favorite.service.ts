import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class FavoriteService {
  private url = 'https://localhost:44394/api/favorites';

  constructor(private httpClient: HttpClient) { }

  isPostUserFavorite(postId, userId) {
    return this.httpClient.get(this.url + '/' + postId + '/' + userId);
  }

  makePostUserFavorite(postId, userId) {
    return this.httpClient.post(this.url + '/' + postId + '/' + userId, postId, userId);
  }

  removePostUserFavorite(postId, userId) {
    return this.httpClient.delete(this.url + '/' + postId + '/' + userId);
  }

}


