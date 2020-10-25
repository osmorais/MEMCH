import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Conexao } from '../_models/Conexao';

@Injectable({
  providedIn: 'root'
})
export class ConexaoService {

  baseURL = 'http://10.1.1.3:8080/servidor/servico/conexao';

  constructor(private http: HttpClient) { }

  getConexoes(): Observable<Conexao[]> {
    return this.http.get<Conexao[]>(`${this.baseURL}/listar`);
  }

  deleteConexao(id: number) {
    return this.http.delete(`${this.baseURL}/remover/${id}`);
  }

  postConexao(conexao: Conexao){
    return this.http.post(`${this.baseURL}/cadastrar/json`, conexao);
  }

  putConexao(conexao: Conexao){
    return this.http.put(`${this.baseURL}/alterar`, conexao);
  }
}
