import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FilluserinfoComponent } from './filluserinfo.component';

describe('FilluserinfoComponent', () => {
  let component: FilluserinfoComponent;
  let fixture: ComponentFixture<FilluserinfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FilluserinfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FilluserinfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
