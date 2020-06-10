import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from './user.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styles: [`
    .loggeduser {
      display: block;
      padding: 0.5rem 1rem;
      color: #fff;
    }
  `]
})
export class NavbarComponent implements OnInit {
  loggedIn = false;
  loggedInUser = {};

  constructor(private router: Router, private userService: UserService) { }

  ngOnInit() {
    this.userService.isLoggedInSubject
      .subscribe(status => {
        this.loggedIn = status;
        this.getUser();
      });
  }

  getUser() {
    this.userService.getLoggedInUser()
      .subscribe(
        res => {
          this.loggedInUser = res;
        },
        err => {
          console.log(err);
        },
      );
  }

  onLogout() {
    localStorage.removeItem('token');
    this.loggedIn = false;
    this.router.navigate(['users']);
  }

}
