import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DaftarEntitas } from './daftar-entitas';

describe('DaftarEntitas', () => {
  let component: DaftarEntitas;
  let fixture: ComponentFixture<DaftarEntitas>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DaftarEntitas]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DaftarEntitas);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
