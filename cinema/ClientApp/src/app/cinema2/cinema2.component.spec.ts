import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Cinema2Component } from './cinema2.component';

describe('Cinema2Component', () => {
  let component: Cinema2Component;
  let fixture: ComponentFixture<Cinema2Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Cinema2Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Cinema2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
