import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Masterrekd {
    idrekd: number;
    idparent?: number | null; // ubah jadi bisa null
    mtglevel?: string;
    kdrek: string;
    nmrek?: string;
    kdjnspjk?: string;
    type?: string;
    status?: string;
    createby?: string;
}

@Injectable({
    providedIn: 'root'
})
export class MasterrekdService {
    private apiUrl = 'http://localhost:5056/api/masterrekd';

    constructor(private http: HttpClient) { }

    getAll(): Observable<Masterrekd[]> {
        return this.http.get<Masterrekd[]>(this.apiUrl);
    }

    getById(id: number): Observable<Masterrekd> {
        return this.http.get<Masterrekd>(`${this.apiUrl}/${id}`);
    }

    create(data: Masterrekd): Observable<Masterrekd> {
        return this.http.post<Masterrekd>(this.apiUrl, data);
    }

    update(id: number, data: Masterrekd): Observable<Masterrekd> {
        return this.http.put<Masterrekd>(`${this.apiUrl}/${id}`, data);
    }

    delete(id: number): Observable<void> {
        return this.http.delete<void>(`${this.apiUrl}/${id}`);
    }
}
