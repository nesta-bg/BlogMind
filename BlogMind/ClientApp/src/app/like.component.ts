import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-like',
  template: `
    <i
      class="fa fa-heart mr-1"
      [class.highlighted]="iLike"
      (click)="onClick()">
    </i>
    <span>{{ totalLikes }}</span>
  `,
  styles: [`
    .fa-heart {
      color: #ccc;
      cursor: pointer;
    }
    .highlighted {
      color: deeppink;
    }
  `]
})
export class LikeComponent {
  @Input() iLike = false;
  @Input() totalLikes = 0;
  @Input() commentId = 0;
  @Output() change = new EventEmitter();

  onClick() {
      this.iLike = !this.iLike;
      let like = this.iLike ? 1 : -1;
      this.totalLikes += like;

      this.change.emit({ newValue: like, commentId: this.commentId });
  }
}
