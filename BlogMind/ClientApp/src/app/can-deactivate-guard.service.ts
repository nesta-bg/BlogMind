import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CanDeactivate } from '@angular/router';

export interface CanComponentDeactivate {
    canDeactivate: () => Observable<boolean> | boolean;
}

@Injectable({
    providedIn: 'root',
})

export class CanDeactivateGuardService implements CanDeactivate<CanComponentDeactivate> {

    canDeactivate(component: CanComponentDeactivate) {
        return component.canDeactivate && component.canDeactivate();
    }
}
