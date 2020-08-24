import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Usuario } from '../_models/Usuario';
import { JsonPipe } from '@angular/common';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {
  baseURL = 'http://localhost:8080/servidor/servico/usuario/consultar/json';

  constructor(private http: HttpClient) { }


  // tslint:disable-next-line: typedef
  postDoLogin(usuario: Usuario) {
    console.log(this.http.request);
    return this.http.post(this.baseURL, usuario);
  }
}
