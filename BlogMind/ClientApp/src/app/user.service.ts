import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from './user';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private url = 'https://localhost:44394/api/appusers';

  private getUserUrl(userId) {
    return this.url + '/' + userId;
  }

  constructor(private httpClient: HttpClient) { }

  getUser(userId) {
    return this.httpClient.get<User>(this.getUserUrl(userId));
  }

  getUsers() {
    return this.httpClient.get<User[]>(this.url);
  }

  addUser(user) {
    return this.httpClient.post(this.url, user);
  }

  updateUser(id, user) {
    return this.httpClient.put(this.getUserUrl(id), user);
  }

  deleteUser(userId) {
    return this.httpClient.delete(this.getUserUrl(userId));
  }
}

