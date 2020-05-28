import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BasicValidators } from './shared/basicValidators';
import { CanComponentDeactivate } from './can-deactivate-guard.service';
import { Observable } from 'rxjs';
import { UserService } from './user.service';
import { Router, ActivatedRoute } from '@angular/router';
import { User, Address } from './user';

@Component({
  templateUrl: './user-form.component.html'
})
export class UserFormComponent implements OnInit, CanComponentDeactivate {
  userForm: FormGroup;
  title: string;
  id: string;

  constructor(fb: FormBuilder, private service: UserService, private router: Router, private route: ActivatedRoute) {
    this.userForm = fb.group({
      name: ['', Validators.required],
      email: ['', BasicValidators.email],
      phoneNumber: [''],
      address: fb.group({
        street: [''],
        suite: [''],
        city: [''],
        zipcode: ['']
      })
    });
  }

  ngOnInit() {
    this.id = this.route.snapshot.paramMap.get('id');
    this.title = this.id ? 'Edit User' : 'New User';

    if (!this.id) {
      return;
    }

    this.service.getUser(this.id)
      .subscribe(
        (user: User) => this.editUser(user),

        response => {
          if (response.status === 404) {
            this.router.navigate(['not-found']);
          }
        });
  }

  editUser(user: User) {
    this.userForm.setValue({
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

  // save() {
  //   if (this.id) {
  //     this.service.updateUser(this.id, this.userForm.value)
  //       .subscribe(x => {
  //         this.userForm.markAsPristine();
  //         this.router.navigate(['users']);
  //       });
  //   } else {
  //     this.service.addUser(this.userForm.value)
  //       .subscribe(x => {
  //         this.userForm.markAsPristine();
  //         this.router.navigate(['users']);
  //       });
  //   }
  // }

  save() {
    let result;

    if (this.id) {
      result = this.service.updateUser(this.id, this.userForm.value);
    } else {
      result = this.service.addUser(this.userForm.value);
    }

    result.subscribe(x => {
      this.userForm.markAsPristine();
      this.router.navigate(['users']);
    });
  }

}
