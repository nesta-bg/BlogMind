import { Component, OnInit } from '@angular/core';
import { User } from './user';
import { UserService } from './user.service';

@Component({
  templateUrl: './users.component.html',
  styles: [`
  .main-img {
    width: 25px;
    height: 25px;
  }
`]
})
export class UsersComponent implements OnInit {
  users: User[] = [];
  userImgUrl = 'https://localhost:44394/uploads/';

  constructor(private userService: UserService) { }

  ngOnInit() {
    this.userService.getUsers()
      .subscribe(users => this.users = users);
  }

   // first server then client
  // deleteUser(user) {
  //   if (confirm('Are you sure you want to delete ' + user.name + '?')) {
  //     let index = this.users.indexOf(user);

  //     this.userService.deleteUser(user.id)
  //       .subscribe(
  //         x => this.users.splice(index, 1),
  //         err => {
  //           alert('Could not delete the user.');
  //         }
  //       );
  //   }
  // }

  // first client then server
  deleteUser(user) {
    if (confirm('Are you sure you want to delete ' + user.name + '?')) {
      let index = this.users.indexOf(user);
      this.users.splice(index, 1);

      this.userService.deleteUser(user.id)
        .subscribe(
          res => null,
          err => {
            alert('Could not delete the user.');
            this.users.splice(index, 0, user);
          }
        );
    }
  }
}
