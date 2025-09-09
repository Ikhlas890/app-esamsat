import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Appgroupuser } from './appgroupuser';

describe('Appgroupuser', () => {
  let component: Appgroupuser;
  let fixture: ComponentFixture<Appgroupuser>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Appgroupuser]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Appgroupuser);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
