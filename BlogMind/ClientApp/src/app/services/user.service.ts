import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { User } from '../user';
import { Subject } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private readonly myAppUrl: string;
  private readonly usersEndpoint: string;

  currentUserSubject: Subject<any> = new Subject();

  constructor(private httpClient: HttpClient) {
    this.myAppUrl = environment.appUrl;
    this.usersEndpoint = 'api/appusers';
  }

  private getUserUrl(userId) {
    return this.myAppUrl + this.usersEndpoint + '/' + userId;
  }

  getUser(userId) {
    return this.httpClient.get<User>(this.getUserUrl(userId));
  }

  getLoggedInUser() {
    let tokenHeader = new HttpHeaders({ Authorization: 'Bearer ' + localStorage.getItem('token') });
    return this.httpClient.get(this.myAppUrl + this.usersEndpoint + '/LoggedInUser', { headers: tokenHeader });
  }

  getUsers() {
    return this.httpClient.get<User[]>(this.myAppUrl + this.usersEndpoint);
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
    return this.httpClient.post(this.myAppUrl + this.usersEndpoint, body);
  }

  updateUser(id, user) {
    return this.httpClient.put(this.getUserUrl(id), user);
  }

  deleteUser(userId) {
    return this.httpClient.delete(this.getUserUrl(userId));
  }

  login(formData) {
    return this.httpClient.post(this.myAppUrl + this.usersEndpoint + '/Login', formData);
  }

  loggedUser(val) {
    this.currentUserSubject.next(val);
  }
}

