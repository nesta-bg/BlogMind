import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BasicValidators } from '../shared/basicValidators';
import { CanComponentDeactivate } from '../shared/can-deactivate-guard.service';
import { Observable } from 'rxjs';
import { UserService } from '../services/user.service';
import { Router, ActivatedRoute } from '@angular/router';
import { User, Address } from '../models/user';
import { ToastrService } from 'ngx-toastr';

@Component({
  templateUrl: './user-form.component.html'
})
export class UserFormComponent implements OnInit, CanComponentDeactivate {
  userForm: FormGroup;
  title: string;
  id: string;

  constructor(
    fb: FormBuilder,
    private service: UserService,
    private router: Router,
    private route: ActivatedRoute,
    private toastr: ToastrService) {
      this.userForm = fb.group({
        name: ['', Validators.required],
        email: ['', BasicValidators.email],
        phoneNumber: [''],
        userName: ['', Validators.required],
        passwords: fb.group({
          password: ['', [Validators.required, Validators.minLength(6)]],
          confirmPassword: ['', Validators.required]
        }, { validator: this.comparePasswords }),
        address: fb.group({
          street: [''],
          suite: [''],
          city: [''],
          zipcode: ['']
        })
      });
  }

  comparePasswords(fb: FormGroup) {
    let confirmPswrdCtrl = fb.get('confirmPassword');
    // passwordMismatch
    // confirmPswrdCtrl.errors={passwordMismatch:true}
    if (confirmPswrdCtrl.errors == null || 'passwordMismatch' in confirmPswrdCtrl.errors) {
      if (fb.get('password').value !== confirmPswrdCtrl.value) {
        confirmPswrdCtrl.setErrors({ passwordMismatch: true });
      } else {
        confirmPswrdCtrl.setErrors(null);
      }
    }
  }

  ngOnInit() {
    this.id = this.route.snapshot.paramMap.get('id');
    this.title = this.id ? 'Edit User' : 'New User';

    if (!this.id) {
      return;
    }

    this.userForm.get('userName').disable();
    this.userForm.get('passwords').disable();
    this.service.getUser(this.id)
      .subscribe(
        (user: User) => this.editUser(user),

        response => {
          if (response.status === 404) {
            this.router.navigate(['not-found']);
          }
        }
      );
  }

  editUser(user: User) {
    this.userForm.patchValue({
      name: user.name,
      email: user.email,
      phoneNumber: user.phoneNumber,
      address: {
        street: user.address.street,
        suite: user.address.suite,
        city: user.address.city,
        zipcode: user.address.zipcode
      } as Address
    });

  }

  canDeactivate(): Observable<boolean> | boolean {
    if (this.userForm.dirty) {
      return confirm('Your changes are unsaved!! Are you sure you want to navigate away?');
    }
    return true;
  }

  save() {
    if (this.id) {
      this.service.updateUser(this.id, this.userForm.value)
        .subscribe(x => {
          this.toastr.success('User\'s details updated!', 'Updating successful.');
          this.userForm.markAsPristine();
          this.router.navigate(['users']);
        },
        err => {
          console.log(err);
        });
    } else {
      this.service.addUser(this.userForm)
      .subscribe(
        (x: any) => {
          if (x.succeeded) {
            this.toastr.success('New user created!', 'Registration successful.');
            this.userForm.markAsPristine();
            this.router.navigate(['users']);
          } else {
            x.errors.forEach(element => {
              switch (element.code) {
                case 'DuplicateUserName':
                  this.toastr.error('Username is already taken', 'Registration failed.');
                  break;

                default:
                  this.toastr.error(element.description, 'Registration failed.');
                  break;
              }
            });
          }
        },
        err => {
          console.log(err);
        }
      );
    }
  }

}
