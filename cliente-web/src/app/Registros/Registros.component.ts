import { Component, OnInit } from '@angular/core';
import { RegistroService } from '../_services/registro.service';
import { Registro } from '../_models/Registro';
import { Hidrometro } from '../_models/Hidrometro';
import { HidrometroService } from '../_services/hidrometro.service';

@Component({
  // tslint:disable-next-line: component-selector
  selector: 'app-Registros',
  templateUrl: './Registros.component.html',
  styleUrls: ['./Registros.component.css']
})
export class RegistrosComponent implements OnInit {

  registros: Registro[];
  hidrometro: Hidrometro;
  constructor(private registroService: RegistroService,
              private hidrometroService: HidrometroService) { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
    this.getRegistros();
    // this.getHidrometro();
  }

  // tslint:disable-next-line: typedef
  getRegistros(){
    // tslint:disable-next-line: variable-name
    this.registroService.getRegistros().subscribe((_registros: Registro[]) => {
      this.registros = _registros;
      console.log(_registros);
    }, error => {
      console.log(error);
    });
  }

  // tslint:disable-next-line: typedef
  getHidrometro(){
    // tslint:disable-next-line: variable-name
    this.hidrometroService.getHidrometro(12).subscribe((_hidrometro: Hidrometro) => {
      this.hidrometro = _hidrometro;
      console.log(_hidrometro);
    },
      error => {
        console.log();
    });
  }
}
