import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { retry, catchError } from 'rxjs/operators';
import { throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PhotoService {
  private url = 'https://localhost:44394/api/appusers';

  constructor(private httpClient: HttpClient) { }

  upload(userId, photo) {
    let formData = new FormData();
    formData.append('file', photo);
    return this.httpClient.post(this.url + '/' + userId + '/photo', formData )
      .pipe(
        retry(3),
        catchError(this.handleError)
      );
  }

  handleError(error: HttpErrorResponse) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      // client-side error
      errorMessage = `Error: ${error.error.message}`;
    } else {
      // server-side error
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.error}`;
    }
    console.error(errorMessage);
    return throwError(errorMessage);
  }
}
