import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Registro } from '../_models/Registro';

@Injectable({
  providedIn: 'root'
})
export class RegistroService {

  baseURL = 'http://10.1.1.3:8080/servidor/servico/registro/';

  constructor(private http: HttpClient) { }

  // tslint:disable-next-line: typedef
  getRegistros(): Observable<Registro[]>{
    return this.http.get<Registro[]>(this.baseURL + 'listar/json');
  }
}
