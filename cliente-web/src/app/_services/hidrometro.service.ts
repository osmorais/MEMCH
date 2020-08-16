import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Hidrometro } from '../_models/Hidrometro';

@Injectable({
  providedIn: 'root'
})
export class HidrometroService {

  baseURL = 'http://10.1.1.3:8080/servidor/servico/hidrometro/';

  constructor(private http: HttpClient) { }

  getHidrometro(id: number): Observable<Hidrometro>{
    return this.http.get<Hidrometro>(this.baseURL + 'consultar/json/' + id);
  }

  postHidrometro(hidrometro: Hidrometro): Observable<Hidrometro>{
    return this.http.post<Hidrometro>(this.baseURL + 'cadastrar/json/', hidrometro);
  }
}
