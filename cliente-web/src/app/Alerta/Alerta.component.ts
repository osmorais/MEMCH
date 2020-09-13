import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Alerta } from '../_models/Alerta';
import { AlertaService } from '../_services/alerta.service';

@Component({
  // tslint:disable-next-line: component-selector
  selector: 'app-Alerta',
  templateUrl: './Alerta.component.html',
  styleUrls: ['./Alerta.component.css']
})
export class AlertaComponent implements OnInit {
  alertas: Alerta[];

  constructor(private toastr: ToastrService,
              private alertaService: AlertaService) { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
    this.getAlertas();
  }

  // tslint:disable-next-line: typedef
  getAlertas() {
    // tslint:disable-next-line: variable-name
    this.alertaService.getAlertas().subscribe((_alertas: Alerta[]) => {
      this.alertas = _alertas;
      if (this.alertas.length > 1) { this.toastr.info(this.alertas.length + ' alertas foram retornados!'); }
      // tslint:disable-next-line: triple-equals
      if (this.alertas.length == 1) { this.toastr.info(this.alertas.length + ' alerta foi retornado!'); }
      console.log(_alertas);
    }, error => {
      this.toastr.error('Não foi possível recuperar os dados de Alertas.', 'Verifique sua conexão');
      console.log(error);
    });
  }
}
