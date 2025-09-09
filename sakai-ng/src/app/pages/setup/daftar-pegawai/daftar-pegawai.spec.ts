import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DaftarPegawai } from './daftar-pegawai';

describe('DaftarPegawai', () => {
  let component: DaftarPegawai;
  let fixture: ComponentFixture<DaftarPegawai>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DaftarPegawai]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DaftarPegawai);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
