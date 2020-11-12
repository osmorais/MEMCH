import { Injectable } from '@angular/core';
import { Usuario } from '../_models/Usuario';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  public usuarioAutenticado: boolean;
  currentUsuario: Usuario;

constructor() { }

  autenticarUsuario(usuario: Usuario){
    this.usuarioAutenticado = true;
    this.currentUsuario = usuario;
    localStorage.setItem('currentUsuarioID', this.currentUsuario.id.toString())
  }

  desautenticarUsuario(){
    this.usuarioAutenticado = false;
  }
}
