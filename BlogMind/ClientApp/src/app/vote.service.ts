import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class VoteService {
  private url = 'https://localhost:44394/api/votes';

  constructor(private httpClient: HttpClient) { }

  getUserVote(postId, userId) {
    return this.httpClient.get(this.url + '/' + postId + '/user/' + userId);
  }

  getVoteCountExcludingUser(postId, userId) {
    return this.httpClient.get(this.url + '/' + postId + '/' + userId);
  }

  addUserVote(postId, userId, mark) {
    return this.httpClient.post(this.url + '/' + postId + '/' + userId + '/' + mark, postId, userId);
  }

  deleteUserVote(postId, userId) {
    return this.httpClient.delete(this.url + '/' + postId + '/' + userId);
  }

}

