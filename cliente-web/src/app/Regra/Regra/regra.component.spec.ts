/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { RegraComponent } from './regra.component';

describe('RegraComponent', () => {
  let component: RegraComponent;
  let fixture: ComponentFixture<RegraComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RegraComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RegraComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
