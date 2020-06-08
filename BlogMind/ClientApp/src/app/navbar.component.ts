import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from './user.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styles: []
})
export class NavbarComponent implements OnInit {
  loggedIn = false;

  constructor(private router: Router, private userService: UserService) { }

  ngOnInit() {
    this.userService.isLoggedInSubject
      .subscribe(status => {
        this.loggedIn = status;
    });
  }

  onLogout() {
    localStorage.removeItem('token');
    this.loggedIn = false;
    this.router.navigate(['users']);
  }

}
