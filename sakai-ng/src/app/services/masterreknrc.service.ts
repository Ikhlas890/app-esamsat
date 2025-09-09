import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Masterreknrc {
    idreknrc: number;
    mtglevel?: string;
    kdrek: string;
    nmrek: string;
    type?: string;
}

@Injectable({
    providedIn: 'root'
})
export class MasterreknrcService {
    private apiUrl = 'http://localhost:5056/api/masterreknrc';

    constructor(private http: HttpClient) { }

    getAll(): Observable<Masterreknrc[]> {
        return this.http.get<Masterreknrc[]>(this.apiUrl);
    }

    getById(id: number): Observable<Masterreknrc> {
        return this.http.get<Masterreknrc>(`${this.apiUrl}/${id}`);
    }

    create(data: Masterreknrc): Observable<Masterreknrc> {
        return this.http.post<Masterreknrc>(this.apiUrl, data);
    }

    update(id: number, data: Masterreknrc): Observable<Masterreknrc> {
        return this.http.put<Masterreknrc>(`${this.apiUrl}/${id}`, data);
    }

    delete(id: number): Observable<void> {
        return this.http.delete<void>(`${this.apiUrl}/${id}`);
    }

    // Tambahan: ambil data khusus untuk p-select/autocomplete dengan query opsional
    getForSelect(query: string = ''): Observable<Masterreknrc[]> {
        let params = new HttpParams();
        if (query) {
            params = params.set('query', query);
        }
        return this.http.get<Masterreknrc[]>(`${this.apiUrl}/for-select`, { params });
    }
}
