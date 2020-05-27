import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BasicValidators } from './shared/basicValidators';
import { CanComponentDeactivate } from './can-deactivate-guard.service';
import { Observable } from 'rxjs';
import { UserService } from './user.service';
import { Router } from '@angular/router';

@Component({
  templateUrl: './user-form.component.html'
})
export class UserFormComponent implements OnInit, CanComponentDeactivate {
  userForm: FormGroup;

  constructor(fb: FormBuilder, private service: UserService, private router: Router) {
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
