import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Masterktp {
    idktp: number,
    nip: string,
    nik: string,
    nama: string,
    agama: string,
    nohp: string,
    alamat: string,
    tgldaftar: string,
    idprovinsi: number,
    idkabkokta: number,
    idkecamatan: number,
    idkelurahan: number,
    idrw: number,
    idrt: number,
    kdrt: string,
    nikah: number,
    tempatlahir: string,
    tgllahir: string,
    tglregistrasi: string,
    nokk: string,
    nobpjs: string,
    goldarah: string,
    email: string,
    pendidikan: string,
    jeniskelamin: string,
    dusun: string,
    pekerjaan: string,
    namaayah: string,
    namaibu: string,
    negara: string,
    statwn: string,
    statint: string,
    tglint: string,
    ket: string,
    createby: string,
    createdate: string,
    updateby: string,
    updatedate: string,
}

@Injectable({ providedIn: 'root' })
export class MasterktpService {
    private apiUrl = 'http://localhost:5056/api/masterktp';

    constructor(private http: HttpClient) { }

    getAll(): Observable<Masterktp[]> {
        return this.http.get<Masterktp[]>(this.apiUrl);
    }

    // Tambahan: ambil data khusus untuk p-select/autocomplete dengan query opsional
    getForSelect(query: string = ''): Observable<Masterktp[]> {
        let params = new HttpParams();
        if (query) {
            params = params.set('query', query);
        }
        return this.http.get<Masterktp[]>(`${this.apiUrl}/for-select`, { params });
    }
}
