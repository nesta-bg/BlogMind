import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { PhotoService } from './services/photo.service';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { UserService } from './services/user.service';
import { User } from './user';

@Component({
  template: `
  <h2>Add a Photo (80x80)</h2>
  <div>
    <input type="file" (change)="uploadPhoto()" #fileInput>
  </div>
  <img [src]="user?.photo ? userImgUrl + user.photo : userImgUrl + 'no-image.png'" class="img-thumbnail mt-2">
  <div *ngIf="user?.photo != null">
    <i (click)="deletePhoto(user?.id)" class="btn btn-danger mt-1">Delete The Photo</i>
  </div>
  `
})
export class PhotosComponent implements OnInit {
  id: string;
  @ViewChild('fileInput', { static: false }) fileInput: ElementRef;
  user: User = null;
  userImgUrl = 'https://localhost:44394/uploads/';

  constructor(
    private photoService: PhotoService,
    private route: ActivatedRoute,
    private router: Router,
    private toastr: ToastrService,
    private userService: UserService) { }

  ngOnInit() {
    this.id = this.route.snapshot.paramMap.get('id');

    this.userService.getUser(this.id)
      .subscribe(user => this.user = user);
  }

  uploadPhoto() {
    let nativeElement: HTMLInputElement = this.fileInput.nativeElement;

    this.photoService.upload(this.id, nativeElement.files[0])
      .subscribe(x => {
        this.toastr.success('User\'s Photo Was Uploaded Successfully!', 'Success');
        this.router.navigate(['users']);
      },
      err => {
        this.toastr.error(err, 'Error');
      });
  }

  deletePhoto(userId) {
    this.photoService.delete(userId)
      .subscribe(x => {
        // console.log(x);
        this.toastr.success('User\'s Photo Was Deleted Successfully!', 'Success');
        this.router.navigate(['users']);
      },
      err => {
        this.toastr.error('User\'s Photo Was Not Deleted!', 'Error');
      });
  }

}
