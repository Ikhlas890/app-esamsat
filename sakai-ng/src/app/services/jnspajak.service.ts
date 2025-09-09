import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Jnspajak {
    kdjnspjk: string,
    nmjnspjk: string,
    kterangan: string,
    createby: string,
    createdate: string,
    updateby: string,
    updatedate: string,
}

@Injectable({ providedIn: 'root' })
export class JnspajakService {
    private apiUrl = 'http://localhost:5056/api/jnspajak';

    constructor(private http: HttpClient) { }

    getAll(): Observable<Jnspajak[]> {
        return this.http.get<Jnspajak[]>(this.apiUrl);
    }
}
