import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Usuario } from '../_models/Usuario';
import { JsonPipe } from '@angular/common';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {
  baseURL = 'http://10.1.1.3:8080/servidor/servico/usuario';

  constructor(private http: HttpClient) { }

  postLogin(usuario: Usuario) {
    return this.http.post(`${this.baseURL}/consultarLogin`, usuario);
  }

  postUsuario(usuario: Usuario) {
    return this.http.post(`${this.baseURL}/cadastrar`, usuario);
  }

  putUsuario(usuario: Usuario) {
    return this.http.put(`${this.baseURL}/alterar`, usuario);
  }

  getUsuario(id:number) {
    return this.http.get(`${this.baseURL}/consultar/${id}`);
  }
}
