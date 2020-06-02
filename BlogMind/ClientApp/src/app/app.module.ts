import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar.component';
import { HomeComponent } from './home.component';
import { UsersComponent } from './users.component';
import { PostsComponent } from './posts.component';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { UserFormComponent } from './user-form.component';
import { CanDeactivateGuardService } from './can-deactivate-guard.service';
import { NotFoundComponent } from './not-found.component';
import { SpinnerComponent } from './shared/spinner.component';
import { PhotosComponent } from './photos.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    HomeComponent,
    UsersComponent,
    PostsComponent,
    UserFormComponent,
    NotFoundComponent,
    SpinnerComponent,
    PhotosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      preventDuplicates: true,
      timeOut: 2000,
      closeButton: true,
      progressBar: true,
      progressAnimation: 'increasing'
    })
  ],
  providers: [CanDeactivateGuardService],
  bootstrap: [AppComponent]
})
export class AppModule { }
