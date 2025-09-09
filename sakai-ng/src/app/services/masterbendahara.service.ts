import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Masterbendahara {
  idbend: number;
  idpegawai: number | null;
  idupt: number | null;
  idbank: number;
  norek: string;
  namarek: string;
  jnsbend: string;
  status: string;
  jabatan?: string | null;
  pangkat?: string | null;
  uid?: string | null;
  koordinator?: number | null;
  idreknrc?: number | null;
  telepon?: string | null;
  ket?: string | null;
  createby?: string | null;
  createdate?: string | null;
  updateby?: string | null;
  updatedate?: string | null;

  // JOIN DATA
  nama?: string | null;
  namabank?: string | null;
  nmrek?: string | null;
  nmupt?: string | null;
}


@Injectable({ providedIn: 'root' })
export class MasterbendaharaService {
    private apiUrl = 'http://localhost:5056/api/masterbendahara';

    constructor(private http: HttpClient) { }

    getAll(): Observable<Masterbendahara[]> {
        return this.http.get<Masterbendahara[]>(this.apiUrl);
    }

    create(data: Masterbendahara): Observable<Masterbendahara> {
        return this.http.post<Masterbendahara>(this.apiUrl, data);
    }


    update(id: number, data: Masterbendahara): Observable<Masterbendahara> {
        return this.http.put<Masterbendahara>(`${this.apiUrl}/${id}`, data);
    }

    delete(id: number): Observable<void> {
        return this.http.delete<void>(`${this.apiUrl}/${id}`);
    }
}
