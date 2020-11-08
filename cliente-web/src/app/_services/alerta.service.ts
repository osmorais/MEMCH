import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Alerta } from '../_models/Alerta';

@Injectable({
  providedIn: 'root'
})
export class AlertaService {

  baseURL = ':8080/servidor/servico/alerta';

  constructor(private http: HttpClient) { }

  getAlertas(hidrometroID: number, host: string): Observable<Alerta[]> {
    return this.http.get<Alerta[]>(`http://${host}${this.baseURL}/listar/json/${hidrometroID}`);
  }
}
