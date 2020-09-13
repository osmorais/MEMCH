import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Alerta } from '../_models/Alerta';

@Injectable({
  providedIn: 'root'
})
export class AlertaService {

  baseURL = 'http://10.1.1.3:8080/servidor/servico/alerta/';

  constructor(private http: HttpClient) { }

  // tslint:disable-next-line: typedef
  getAlertas(): Observable<Alerta[]> {
    return this.http.get<Alerta[]>(this.baseURL + 'listar/json/');
  }
}
