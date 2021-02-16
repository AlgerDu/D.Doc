import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DbDocComponent } from './db-doc.component';

describe('DbDocComponent', () => {
  let component: DbDocComponent;
  let fixture: ComponentFixture<DbDocComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DbDocComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DbDocComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
