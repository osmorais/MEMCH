import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
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
  public loading = false;
  hidrometroID: number;

  constructor(private route: ActivatedRoute,
              private toastr: ToastrService,
              private alertaService: AlertaService) {
                this.route.params.subscribe(params => this.hidrometroID = params.id);
              }

  ngOnInit() {
    this.getAlertas();
  }

  getAlertas() {
    this.loading = true;
    this.alertaService.getAlertas(this.hidrometroID, localStorage.getItem('host'))
    .subscribe((_alertas: Alerta[]) => {
      this.loading = false;
      this.alertas = _alertas;
      if (this.alertas.length > 1) { this.toastr.info(this.alertas.length + ' alertas foram retornados!'); }
      
      if (this.alertas.length == 1) { this.toastr.info(this.alertas.length + ' alerta foi retornado!'); }
      console.log(_alertas);
    }, error => {
      this.loading = false;
      this.toastr.error('Não foi possível recuperar os dados de Alertas.', 'Verifique sua conexão');
      console.log(error);
    });
  }
}
