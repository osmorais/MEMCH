import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  public usuarioAutenticado: boolean;

constructor() { }

  autenticarUsuario(){
    this.usuarioAutenticado = true;
  }

  desautenticarUsuario(){
    this.usuarioAutenticado = false;
  }
}
