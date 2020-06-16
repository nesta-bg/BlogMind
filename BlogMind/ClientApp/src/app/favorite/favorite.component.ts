import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-favorite',
  template: `
        <i class= "mr-2 fa"
           [class.fa-star-o]="!isFavorite"
           [class.fa-star] = "isFavorite"
           (click) = "onClick()">
        </i>`,
  styles: [`
        .fa-star {
            color: orange;
        }
    `]
})

export class FavoriteComponent {
  @Input() isFavorite = false;
  @Output() change = new EventEmitter();

  onClick() {
    this.isFavorite = !this.isFavorite;
    this.change.emit({ newValue: this.isFavorite });
  }
}
