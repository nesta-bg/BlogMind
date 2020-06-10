import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { User } from './user';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private url = 'https://localhost:44394/api/appusers';
  currentUserSubject: Subject<any> = new Subject();

  private getUserUrl(userId) {
    return this.url + '/' + userId;
  }

  constructor(private httpClient: HttpClient) { }

  getUser(userId) {
    return this.httpClient.get<User>(this.getUserUrl(userId));
  }

  getLoggedInUser() {
    let tokenHeader = new HttpHeaders({Authorization: 'Bearer ' + localStorage.getItem('token') });
    return this.httpClient.get(this.url + '/LoggedInUser', {headers: tokenHeader});
  }

  getUsers() {
    return this.httpClient.get<User[]>(this.url);
  }

  addUser(userForm) {
    let body = {
      Name: userForm.value.name,
      Email: userForm.value.email,
      PhoneNumber: userForm.value.phoneNumber,
      UserName: userForm.value.userName,
      Password: userForm.value.passwords.password,
      Address: {
        Street: userForm.value.address.street,
        Suite: userForm.value.address.suite,
        City: userForm.value.address.city,
        Zipcode: userForm.value.address.zipcode
      }
    };
    return this.httpClient.post(this.url, body);
  }

  updateUser(id, user) {
    return this.httpClient.put(this.getUserUrl(id), user);
  }

  deleteUser(userId) {
    return this.httpClient.delete(this.getUserUrl(userId));
  }

  login(formData) {
    return this.httpClient.post(this.url + '/Login', formData);
  }

  loggedUser(val) {
    this.currentUserSubject.next(val);
  }
}

