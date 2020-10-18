import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Regra } from '../_models/Regra';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RegraService {

  baseURL = 'http://10.1.1.3:8080/servidor/servico/regra';

  constructor(private http: HttpClient) { }

  getRegras(id: number): Observable<Regra[]> {
    return this.http.get<Regra[]>(`${this.baseURL}/listar/json/${id}`);
  }

  deleteRegra(id: number) {
    return this.http.delete(`${this.baseURL}/remover/json/${id}`);
  }

  postRegra(id: number, regra: Regra){
    return this.http.post(`${this.baseURL}/cadastrar/json/${id}`, regra);
  }

  putRegra(id: number, regra: Regra){
    return this.http.post(`${this.baseURL}/alterar/json/${id}`, regra);
  }
}
