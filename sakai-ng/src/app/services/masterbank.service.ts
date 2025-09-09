import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Masterbank {
  idbank: number;
  kodebank?: string;
  namabank: string;
  akronimbank?: string;
  cabangbank?: string;
  alamatbank?: string;
  status?: string;
  createby?: string;
  createdate?: string;   
  updateby?: string;     
  updatedate?: string;   
}

@Injectable({ providedIn: 'root' })
export class MasterbankService {
  private apiUrl = 'http://localhost:5056/api/masterbank';

  constructor(private http: HttpClient) {}

  getAll(): Observable<Masterbank[]> {
    return this.http.get<Masterbank[]>(this.apiUrl);
  }
}
