import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KodeRekening } from './kode-rekening';

describe('KodeRekening', () => {
  let component: KodeRekening;
  let fixture: ComponentFixture<KodeRekening>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [KodeRekening]
    })
    .compileComponents();

    fixture = TestBed.createComponent(KodeRekening);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
