import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, tap } from 'rxjs';

interface LoginRequest {
  userid: string;
  password: string;
}

interface RegisterRequest {
  userid: string;
  nama: string;
  email: string;
  password: string;
  kdgroup: string;
}

export interface UserResponse {
  userid: string;
  nama?: string;
  email?: string;
  kdgroup: string;
  password?: string; // ← jadikan optional
  idupt?: number;
  idpeg?: number;
  nik?: string;
  createdate?: Date;
}


@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private apiUrl = 'http://localhost:5056/api/auth'; // Sesuaikan dengan backend Anda

  constructor(private http: HttpClient) { }

  login(data: LoginRequest): Observable<any> {
    return this.http.post(`${this.apiUrl}/login`, data, { withCredentials: true });
  }

  register(data: RegisterRequest): Observable<any> {
    return this.http.post(`${this.apiUrl}/register`, data, { withCredentials: true });
  }

  getUsers(): Observable<UserResponse[]> {
    return this.http.get<UserResponse[]>(`${this.apiUrl}/users`, { withCredentials: true });
  }

  updateUser(userid: string, data: Partial<UserResponse>): Observable<any> {
    return this.http.put(`${this.apiUrl}/users/${userid}`, data, { withCredentials: true });
  }

  deleteUser(userid: string): Observable<any> {
    return this.http.delete(`${this.apiUrl}/users/${userid}`, { withCredentials: true });
  }

  logout(): Observable<any> {
    return this.http.post(`${this.apiUrl}/logout`, {}, { withCredentials: true });
  }

  getLoggedUser(): Observable<any> {
    return this.http.get(`${this.apiUrl}/me`, { withCredentials: true });
  }
}
