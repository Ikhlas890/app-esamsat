import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Masterjnsstrurek {
  mtglevel: string;
  nmlevel: string;
  kterangan?: string;
  createby?: string;
  createdate?: string;   
  updateby?: string;     
  updatedate?: string;   
}

@Injectable({ providedIn: 'root' })
export class MasterjnsstrurekService {
  private apiUrl = 'http://localhost:5056/api/jnsstrurek';

  constructor(private http: HttpClient) {}

  getAll(): Observable<Masterjnsstrurek[]> {
    return this.http.get<Masterjnsstrurek[]>(this.apiUrl);
  }
}
