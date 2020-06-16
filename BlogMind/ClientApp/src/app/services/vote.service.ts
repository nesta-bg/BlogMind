import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class VoteService {
  private readonly myAppUrl: string;
  private readonly votesEndpoint: string;

  constructor(private httpClient: HttpClient) {
    this.myAppUrl = environment.appUrl;
    this.votesEndpoint = 'api/votes';
  }

  getUserVote(postId, userId) {
    return this.httpClient.get(this.myAppUrl + this.votesEndpoint + '/' + postId + '/user/' + userId);
  }

  getVoteCountExcludingUser(postId, userId) {
    return this.httpClient.get(this.myAppUrl + this.votesEndpoint + '/' + postId + '/' + userId);
  }

  addUserVote(postId, userId, mark) {
    return this.httpClient.post(this.myAppUrl + this.votesEndpoint + '/' + postId + '/' + userId + '/' + mark, postId, userId);
  }

  deleteUserVote(postId, userId) {
    return this.httpClient.delete(this.myAppUrl + this.votesEndpoint + '/' + postId + '/' + userId);
  }

}

