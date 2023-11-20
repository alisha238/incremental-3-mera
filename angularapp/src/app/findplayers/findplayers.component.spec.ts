import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FindplayersComponent } from './findplayers.component';

describe('FindplayersComponent', () => {
  let component: FindplayersComponent;
  let fixture: ComponentFixture<FindplayersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FindplayersComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FindplayersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
