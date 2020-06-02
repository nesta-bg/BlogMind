import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PhotoService {
  private url = 'https://localhost:44394/api/appusers';

  constructor(private httpClient: HttpClient) { }

  upload(userId, photo) {
    let formData = new FormData();
    formData.append('file', photo);
    return this.httpClient.post(this.url + '/' + userId + '/photo', formData);
  }
}
