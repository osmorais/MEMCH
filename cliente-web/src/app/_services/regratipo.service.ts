import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { RegraTipo } from '../_models/RegraTipo';

@Injectable({
  providedIn: 'root'
})
export class RegratipoService {

  baseURL = ':8080/servidor/servico/regratipo';

  constructor(private http: HttpClient) { }

  getAllRegraTipo(host: string): Observable<RegraTipo[]> {
    return this.http.get<RegraTipo[]>(`http://${host}${this.baseURL}/listar/json/`);
  }
}
