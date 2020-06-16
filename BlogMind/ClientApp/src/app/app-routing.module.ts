import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { UsersComponent } from './users/users.component';
import { PostsComponent } from './posts/posts.component';
import { UserFormComponent } from './user-form/user-form.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { PhotosComponent } from './photos/photos.component';

import { CanDeactivateGuardService } from './shared/can-deactivate-guard.service';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: HomeComponent },
    { path: 'users', component: UsersComponent },
    {
        path: 'users/new',
        component: UserFormComponent,
        canDeactivate: [ CanDeactivateGuardService ]
    },
    {
        path: 'users/:id',
        component: UserFormComponent,
        canDeactivate: [ CanDeactivateGuardService ]
    },
    { path: 'login', component: LoginComponent },
    { path: 'posts', component: PostsComponent },
    { path: 'users/:id/photo', component: PhotosComponent},
    { path: 'not-found', component: NotFoundComponent },
    { path: '**', redirectTo: 'home' }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule {

}
