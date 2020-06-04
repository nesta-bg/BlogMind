import { Component, Input, Output, EventEmitter } from '@angular/core';
import { OnChanges } from '@angular/core';
import { Post } from '../post';

@Component({
  selector: 'app-pagination',
  template: `
    <div *ngIf="items.length > pageSize">
        <ul class="pagination">
            <li [class.disabled]="currentPage == 1" class="page-item">
                <a (click)="previous()" class="page-link"><span aria-hidden="true">&laquo;</span></a>
            </li>
            <li [class.active]="currentPage == page" *ngFor="let page of pages" (click)="changePage(page)" class="page-item">
                <a class="page-link">{{ page }}</a>
            </li>
            <li [class.disabled]="currentPage == pages.length" class="page-item">
                <a (click)="next()" class="page-link"><span aria-hidden="true">&raquo;</span></a>
            </li>
        </ul>
    </div>
    `
})

export class PaginationComponent implements OnChanges {
  @Input() items: Post[] = [];
  // this property value is bound to a different property name
  // when this component is instantiated in a template.
  @Input('page-size') pageSize = 0;
  @Output('page-changed') pageChanged = new EventEmitter();
  pages: any[];
  currentPage;

  ngOnChanges() {
    this.currentPage = 1;
    let pagesCount = this.items.length / this.pageSize;
    this.pages = [];
    for (let i = 1; i <= pagesCount; i++) {
      this.pages.push(i);
    }
  }

  changePage(page) {
    this.currentPage = page;
    this.pageChanged.emit(page);
  }

  previous() {
    if (this.currentPage === 1) {
      return;
    }

    this.currentPage--;
    this.pageChanged.emit(this.currentPage);
  }

  next() {
    if (this.currentPage === this.pages.length) {
      return;
    }

    this.currentPage++;
    this.pageChanged.emit(this.currentPage);
  }
}

