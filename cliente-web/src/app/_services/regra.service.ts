import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Regra } from '../_models/Regra';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RegraService {

  baseURL = ':8080/servidor/servico/regra';

  constructor(private http: HttpClient) { }

  getRegras(id: number, host: string): Observable<Regra[]> {
    return this.http.get<Regra[]>(`http://${host}${this.baseURL}/listar/json/${id}`);
  }

  deleteRegra(id: number, host: string)  {
    return this.http.delete(`http://${host}${this.baseURL}/remover/json/${id}`);
  }

  postRegra(id: number, host: string,  regra: Regra){
    return this.http.post(`http://${host}${this.baseURL}/cadastrar/json/${id}`, regra);
  }

  putRegra(id: number, host: string,  regra: Regra){
    return this.http.put(`http://${host}${this.baseURL}/alterar/json/${id}`, regra);
  }
}
