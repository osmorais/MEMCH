import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Registro } from '../_models/Registro';

@Injectable({
  providedIn: 'root'
})
export class RegistroService {

  baseURL = ':8080/servidor/servico/registro';

  constructor(private http: HttpClient) { }

  getRegistros(hidrometroID: number, host: string): Observable<Registro[]>{
    return this.http.get<Registro[]>(`http://${host}${this.baseURL}/listar/json/${hidrometroID}`);
  }
}
