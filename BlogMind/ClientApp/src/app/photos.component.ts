import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { PhotoService } from './photo.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  template: `
  <h2>Add a Photo</h2>
  <div>
    <input type="file" (change)="uploadPhoto()" #fileInput>
  </div>
  `
})
export class PhotosComponent implements OnInit {
  id: string;
  @ViewChild('fileInput', { static: false }) fileInput: ElementRef;

  constructor(private photoService: PhotoService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    this.id = this.route.snapshot.paramMap.get('id');
  }

  uploadPhoto() {
    let nativeElement: HTMLInputElement = this.fileInput.nativeElement;

    this.photoService.upload(this.id, nativeElement.files[0])
      .subscribe(x => {
        this.router.navigate(['users']);
      });
  }

}
