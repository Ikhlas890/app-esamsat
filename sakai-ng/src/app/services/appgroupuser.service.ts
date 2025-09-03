import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface AppGroupUser {
  kdgroup: string;
  nmgroup: string;
  ket?: string;
}

@Injectable({
  providedIn: 'root'
})
export class AppgroupuserService {
  private apiUrl = 'http://localhost:5056/api/appgroupuser'; // sesuaikan base URL API Anda

  constructor(private http: HttpClient) {}

  getAll(): Observable<AppGroupUser[]> {
    return this.http.get<AppGroupUser[]>(this.apiUrl);
  }

  getById(kdgroup: string): Observable<AppGroupUser> {
    return this.http.get<AppGroupUser>(`${this.apiUrl}/${kdgroup}`);
  }

  create(data: AppGroupUser): Observable<AppGroupUser> {
    return this.http.post<AppGroupUser>(this.apiUrl, data);
  }

  update(kdgroup: string, data: Partial<AppGroupUser>): Observable<AppGroupUser> {
    return this.http.put<AppGroupUser>(`${this.apiUrl}/${kdgroup}`, data);
  }

  delete(kdgroup: string): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${kdgroup}`);
  }
}
