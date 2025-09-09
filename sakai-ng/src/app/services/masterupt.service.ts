import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Masterupt {
  idupt: number;
  idparent?: number | null;
  kdupt: string;
  nmupt: string;
  kdlevel: string;
  type?: string;
  akroupt?: string;
  alamat?: string;
  telepon?: string;
  idbank?: number | null;
  idkabkota?: number | null;
  kepala?: number | null;
  koordinator?: number | null;
  bendahara?: number | null;
  status: string;
  createby?: string;
  createdate?: string;  
  updateby?: string;     
  updatedate?: string; 
}

@Injectable({ providedIn: 'root' })
export class MasteruptService {
  private apiUrl = 'http://localhost:5056/api/masterupt'; // sesuaikan dengan backend

  constructor(private http: HttpClient) {}

  getAll(): Observable<Masterupt[]> {
    return this.http.get<Masterupt[]>(this.apiUrl);
  }

  create(data: Masterupt): Observable<Masterupt> {
    return this.http.post<Masterupt>(this.apiUrl, data);
  }

  update(id: number, data: Masterupt): Observable<Masterupt> {
    return this.http.put<Masterupt>(`${this.apiUrl}/${id}`, data);
  }

  delete(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}
