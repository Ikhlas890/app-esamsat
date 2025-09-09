import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagementUser } from './management-user';

describe('ManagementUser', () => {
  let component: ManagementUser;
  let fixture: ComponentFixture<ManagementUser>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ManagementUser]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ManagementUser);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
