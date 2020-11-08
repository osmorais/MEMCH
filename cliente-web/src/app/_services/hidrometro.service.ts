import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Hidrometro } from '../_models/Hidrometro';

@Injectable({
  providedIn: 'root'
})
export class HidrometroService {

  baseURL = ':8080/servidor/servico/hidrometro';

  constructor(private http: HttpClient) { }

  getHidrometro(id: number, host: string): Observable<Hidrometro> {
    return this.http.get<Hidrometro>(`http://${host}${this.baseURL}/consultar/json/${id}`);
  }

  getAllHidrometro(host: string): Observable<Hidrometro[]> {
    return this.http.get<Hidrometro[]>(`http://${host}${this.baseURL}/listar`);
  }

  postHidrometro(hidrometro: Hidrometro, host: string): Observable<Hidrometro> {
    return this.http.post<Hidrometro>(`http://${host}${this.baseURL}/cadastrar/json/`, hidrometro);
  }
}
