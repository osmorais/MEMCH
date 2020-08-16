import { Component, OnInit } from '@angular/core';
import { RegistroService } from '../_services/registro.service';

@Component({
  // tslint:disable-next-line: component-selector
  selector: 'app-Registros',
  templateUrl: './Registros.component.html',
  styleUrls: ['./Registros.component.css']
})
export class RegistrosComponent implements OnInit {

  registros: any;
  constructor(private registroService: RegistroService) { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
    this.getRegistros();
  }

  // tslint:disable-next-line: typedef
  getRegistros(){
    this.registroService.getRegistros().subscribe(response => {
      this.registros = response;
      console.log(response);
    }, error => {
      console.log(error);
    }
    );
  }

}
