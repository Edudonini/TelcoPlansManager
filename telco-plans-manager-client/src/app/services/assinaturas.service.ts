import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Assinatura } from '../models/assinatura.model';

@Injectable({
  providedIn: 'root'
})
export class AssinaturasService {
  private apiUrl = 'https://localhost:7001/api/Assinaturas';

  constructor(private http: HttpClient) { }

  getAssinaturas(): Observable<Assinatura[]> {
    return this.http.get<Assinatura[]>(this.apiUrl);
  }

  getAssinatura(id: number): Observable<Assinatura> {
    return this.http.get<Assinatura>(`${this.apiUrl}/${id}`);
  }

  createAssinatura(assinatura: Assinatura): Observable<Assinatura> {
    return this.http.post<Assinatura>(this.apiUrl, assinatura);
  }

  updateAssinatura(id: number, assinatura: Assinatura): Observable<void> {
    return this.http.put<void>(`${this.apiUrl}/${id}`, assinatura);
  }

  deleteAssinatura(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
} 