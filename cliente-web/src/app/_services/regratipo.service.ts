import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { RegraTipo } from '../_models/RegraTipo';

@Injectable({
  providedIn: 'root'
})
export class RegratipoService {
  baseURL = 'http://10.1.1.3:8080/servidor/servico/regratipo/';

  constructor(private http: HttpClient) { }

  getAllRegraTipo(): Observable<RegraTipo[]> {
    return this.http.get<RegraTipo[]>(this.baseURL + 'listar/json/');
  }
}
