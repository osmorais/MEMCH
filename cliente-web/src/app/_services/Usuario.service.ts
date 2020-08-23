import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Usuario } from '../_models/Usuario';
import { JsonPipe } from '@angular/common';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {
  baseURL = 'http://localhost:8080/servidor/servico/usuario/';

  constructor(private http: HttpClient) { }


  // tslint:disable-next-line: typedef
  postDoLogin(usuario: Usuario) {
    return this.http.post(this.baseURL + 'consultar', usuario);
  }
}
