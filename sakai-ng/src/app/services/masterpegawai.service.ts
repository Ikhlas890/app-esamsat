import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Masterpegawai {
  idpegawai: number;
  idktp?: number | null;
  nip?: string;
  nik?: string;
  nama: string;
  idupt?: number | null;
  nmupt: string; 
  status?: string; 
  jabatan?: string; 
  pangkat?: string; 
  golongan?: string; 
  uid?: string; 
  telepon?: string; 
  createby?: string;
  createdate?: string;  
  updateby?: string;     
  updatedate?: string; 
}

@Injectable({ providedIn: 'root' })
export class MasterpegawaiService {
  private apiUrl = 'http://localhost:5056/api/masterpegawai'; // sesuaikan dengan backend

  constructor(private http: HttpClient) {}

  getAll(): Observable<Masterpegawai[]> {
    return this.http.get<Masterpegawai[]>(this.apiUrl);
  }

  create(data: Masterpegawai): Observable<Masterpegawai> {
    return this.http.post<Masterpegawai>(this.apiUrl, data);
  }

  update(id: number, data: Masterpegawai): Observable<Masterpegawai> {
    return this.http.put<Masterpegawai>(`${this.apiUrl}/${id}`, data);
  }

  delete(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
