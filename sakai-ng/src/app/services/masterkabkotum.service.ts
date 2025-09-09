import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Masterkabkotum {
    idkabkota: number,
    idprovinsi: number,
    kdkabkota: string,
    nmkabkota: string,
    akronim: string,
    ibukota: string,
    status: string,
    bpkbid: string,
    createby: string,
    createdate: string,
    updateby: string,
    updatedate: string,
}

@Injectable({ providedIn: 'root' })
export class MasterkabkotumService {
    private apiUrl = 'http://localhost:5056/api/masterkabkotum';

    constructor(private http: HttpClient) { }

    getAll(): Observable<Masterkabkotum[]> {
        return this.http.get<Masterkabkotum[]>(this.apiUrl);
    }
}
