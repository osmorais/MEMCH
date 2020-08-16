import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class RegistroService {

  baseURL = 'http://10.1.1.3:8080/servidor/servico/registro/';

  constructor(private http: HttpClient) { }

  // tslint:disable-next-line: typedef
  getRegistros(){
    return this.http.get(this.baseURL + 'listar/json');
  }
}
