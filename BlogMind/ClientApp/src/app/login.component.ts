import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { UserService } from './user.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html'
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;

  constructor(
    fb: FormBuilder,
    private service: UserService,
    private router: Router,
    private toastr: ToastrService) {
    this.loginForm = fb.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  ngOnInit() {
  }

  login() {
    this.service.login(this.loginForm.value)
      .subscribe((res: any) => {
        localStorage.setItem('token', res.token);
        this.service.isLoggedIn(true);
        this.router.navigateByUrl('posts');
      },
      err => {
        if (err.status == 400) {
          this.toastr.error('Incorrect username or password.', 'Authentication failed.');
        } else {
          console.log(err);
        }
      }
    );
  }

}
