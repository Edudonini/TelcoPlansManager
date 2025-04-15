import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Plano } from '../models/plano.model';

@Injectable({
  providedIn: 'root'
})
export class PlanosService {
  private apiUrl = 'https://localhost:7001/api/Planos';

  constructor(private http: HttpClient) { }

  getPlanos(): Observable<Plano[]> {
    return this.http.get<Plano[]>(this.apiUrl);
  }

  getPlano(id: number): Observable<Plano> {
    return this.http.get<Plano>(`${this.apiUrl}/${id}`);
  }

  createPlano(plano: Plano): Observable<Plano> {
    return this.http.post<Plano>(this.apiUrl, plano);
  }

  updatePlano(id: number, plano: Plano): Observable<void> {
    return this.http.put<void>(`${this.apiUrl}/${id}`, plano);
  }

  deletePlano(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
} 