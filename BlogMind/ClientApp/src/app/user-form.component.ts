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

  constructor(fb: FormBuilder, private service: UserService, private router: Router, private route: ActivatedRoute) {
    this.userForm = fb.group({
      name: ['', Validators.required],
      email: ['', BasicValidators.email],
      phone: [''],
      address: fb.group({
        street: [''],
        suite: [''],
        city: [''],
        zipcode: ['']
      })
    });
  }

  ngOnInit() {
    let id = this.route.snapshot.paramMap.get('id');
    this.title = id ? 'Edit User' : 'New User';

    if (!id) {
      return;
    }

    this.service.getUser(id)
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
      phone: user.phone,
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
    this.service.addUser(this.userForm.value)
      .subscribe(x => {
        this.userForm.markAsPristine();
        this.router.navigate(['users']);
      });
  }
}
