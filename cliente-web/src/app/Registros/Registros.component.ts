import { Component, Input, OnInit } from '@angular/core';
import { RegistroService } from '../_services/registro.service';
import { Registro } from '../_models/Registro';
import { Hidrometro } from '../_models/Hidrometro';
import { HidrometroService } from '../_services/hidrometro.service';
import { ToastrService } from 'ngx-toastr';
import { ActivatedRoute } from '@angular/router';

@Component({
  // tslint:disable-next-line: component-selector
  selector: 'app-Registros',
  templateUrl: './Registros.component.html',
  styleUrls: ['./Registros.component.css']
})
export class RegistrosComponent implements OnInit {
  registros: Registro[];
  hidrometro: Hidrometro;
  hidrometroID: number;
  public loading = false;

  constructor(private route: ActivatedRoute,
              private registroService: RegistroService,
              private hidrometroService: HidrometroService,
              private toastr: ToastrService) {
                this.route.params.subscribe(params => this.hidrometroID = params.id);
              }

  ngOnInit() {
    this.getRegistros();
  }

  getRegistros() {
    this.loading = true;
    this.registroService.getRegistros(this.hidrometroID).subscribe((_registros: Registro[]) => {
      this.loading = false;
      this.registros = _registros;
      if (this.registros.length > 1) { this.toastr.info(this.registros.length + ' registros foram retornados!'); }

      if (this.registros.length == 1) { this.toastr.info(this.registros.length + ' registro foi retornado!'); }
      console.log(_registros);
    }, error => {
      this.loading = false;
      this.toastr.error('Não foi possível recuperar os dados do Cosumo.', 'Verifique sua conexão');
      console.log(error);
    });
  }

  getHidrometro() {
    this.loading = true;
    this.hidrometroService.getHidrometro(this.hidrometroID).subscribe((_hidrometro: Hidrometro) => {
      this.loading = false;
      this.hidrometro = _hidrometro;
      console.log(_hidrometro);
    },
      error => {
        this.loading = false;
        this.toastr.error('Por favor verifique sua conexão', 'Falha de comunicação');
        console.log();
      });
  }
}
