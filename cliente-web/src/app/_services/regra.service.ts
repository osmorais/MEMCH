import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Regra } from '../_models/Regra';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RegraService {

  baseURL = 'http://10.1.1.3:8080/servidor/servico/regra/';

  constructor(private http: HttpClient) { }

  // tslint:disable-next-line: typedef
  getRegrasByHidrometro(id: number): Observable<Regra[]> {
    return this.http.get<Regra[]>(this.baseURL + 'listar/json/' + id);
  }
}
