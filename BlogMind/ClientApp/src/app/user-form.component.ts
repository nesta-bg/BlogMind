import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BasicValidators } from './shared/basicValidators';

@Component({
  templateUrl: './user-form.component.html'
})
export class UserFormComponent implements OnInit {
  userForm: FormGroup;

  constructor(fb: FormBuilder) {
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

}
