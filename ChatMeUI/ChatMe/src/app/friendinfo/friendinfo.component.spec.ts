import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FriendinfoComponent } from './friendinfo.component';

describe('FriendinfoComponent', () => {
  let component: FriendinfoComponent;
  let fixture: ComponentFixture<FriendinfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FriendinfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FriendinfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
