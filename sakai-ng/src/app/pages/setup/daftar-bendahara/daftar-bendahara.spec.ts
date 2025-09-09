import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DaftarBendahara } from './daftar-bendahara';

describe('DaftarBendahara', () => {
  let component: DaftarBendahara;
  let fixture: ComponentFixture<DaftarBendahara>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DaftarBendahara]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DaftarBendahara);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
