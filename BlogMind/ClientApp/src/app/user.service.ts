import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from './user';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private url = 'https://localhost:44394/api/appusers';

  constructor(private httpClient: HttpClient) { }

  getUser(userId) {
    return this.httpClient.get<User>(this.url + '/' + userId);
  }

  getUsers() {
    return this.httpClient.get<User[]>(this.url);
  }

  addUser(user) {
    return this.httpClient.post(this.url, user);
  }
}
