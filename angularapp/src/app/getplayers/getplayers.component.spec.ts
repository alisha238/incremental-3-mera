import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetplayersComponent } from './getplayers.component';

describe('GetplayersComponent', () => {
  let component: GetplayersComponent;
  let fixture: ComponentFixture<GetplayersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetplayersComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetplayersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
