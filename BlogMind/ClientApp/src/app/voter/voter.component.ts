import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-voter',
  template: `
    <div class="voter">
      <i
        class="fa fa-caret-up vote-button"
        [class.highlighted]="myVote == 1"
        (click)="upVote()">
      </i>
      <span class="vote-count ml-1 mr-1">{{ voteCount + myVote }}</span>
      <i
        class="fa fa-caret-down vote-button"
        [class.highlighted]="myVote == -1"
        (click)="downVote()">
      </i>
    </div>
  `,
  styles: [`
    .voter {
      text-align: right;
      color: #999;
    }
    .vote-button {
      cursor: pointer;
    }
    .vote-count {
      font-size: 1.2em;
    }
    .highlighted {
      font-weight: bold;
      color: orange;
    }
  `]
})
export class VoterComponent {
  @Input() voteCount = 0;
  @Input() myVote = 0;
  @Input() postId = 0;
  @Output() vote = new EventEmitter();

  upVote() {
    if (this.myVote != 1) {
      this.myVote += 1;
      this.vote.emit({ myVote: this.myVote, postId: this.postId });
    }
  }
  downVote() {
    if (this.myVote != -1) {
      this.myVote -= 1;
      this.vote.emit({ myVote: this.myVote, postId: this.postId });
    }
  }
}
