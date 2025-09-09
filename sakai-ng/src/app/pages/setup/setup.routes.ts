import { Routes } from '@angular/router';
import { KodeRekening } from './kode-rekening/kode-rekening';
import { DaftarEntitas } from './daftar-entitas/daftar-entitas';
import { DaftarPegawai } from './daftar-pegawai/daftar-pegawai';
import { DaftarBendahara } from './daftar-bendahara/daftar-bendahara';

export default [
    { path: 'kode-rekening', component: KodeRekening },
    { path: 'daftar-entitas', component: DaftarEntitas },
    { path: 'daftar-pegawai', component: DaftarPegawai },
    { path: 'daftar-bendahara', component: DaftarBendahara }
] as Routes;