import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class FavoriteService {
  private readonly myAppUrl: string;
  private readonly favoritesEndpoint: string;

  constructor(private httpClient: HttpClient) {
    this.myAppUrl = environment.appUrl;
    this.favoritesEndpoint = 'api/favorites';
  }

  isPostUserFavorite(postId, userId) {
    return this.httpClient.get(this.myAppUrl + this.favoritesEndpoint + '/' + postId + '/' + userId);
  }

  makePostUserFavorite(postId, userId) {
    return this.httpClient.post(this.myAppUrl + this.favoritesEndpoint + '/' + postId + '/' + userId, postId, userId);
  }

  removePostUserFavorite(postId, userId) {
    return this.httpClient.delete(this.myAppUrl + this.favoritesEndpoint + '/' + postId + '/' + userId);
  }

}


