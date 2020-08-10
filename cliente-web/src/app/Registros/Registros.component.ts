import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  // tslint:disable-next-line: component-selector
  selector: 'app-Registros',
  templateUrl: './Registros.component.html',
  styleUrls: ['./Registros.component.css']
})
export class RegistrosComponent implements OnInit {

  registros: any;
  constructor(private http: HttpClient) { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
    this.getRegistros();
  }

  // tslint:disable-next-line: typedef
  getRegistros(){
    this.http.get('http://10.1.1.3:8080/servidor/servico/registro/listar/json').subscribe(response => {
      this.registros = response;
      console.log(response);
    }, error => {
      console.log(error);
    }
    );
  }

}
