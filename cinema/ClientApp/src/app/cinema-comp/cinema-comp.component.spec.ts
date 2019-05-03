import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CinemaCompComponent } from './cinema-comp.component';

describe('CinemaCompComponent', () => {
  let component: CinemaCompComponent;
  let fixture: ComponentFixture<CinemaCompComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CinemaCompComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CinemaCompComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
