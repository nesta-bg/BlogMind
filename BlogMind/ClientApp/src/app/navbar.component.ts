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
  loggedInUser = null;

  constructor(private router: Router, private userService: UserService) { }

  ngOnInit() {
    this.userService.currentUserSubject
      .subscribe(user => {
        this.loggedInUser = user;
      });
  }

  onLogout() {
    localStorage.removeItem('token');
    this.loggedInUser = null;
    this.router.navigate(['users']);
  }

}
