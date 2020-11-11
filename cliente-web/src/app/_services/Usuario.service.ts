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
    return this.http.post(`${this.baseURL}/consultar`, usuario);
  }

  postUsuario(usuario: Usuario) {
    return this.http.post(`${this.baseURL}/cadastrar`, usuario);
  }
}
