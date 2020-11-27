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
  alertasFiltrados: Alerta[];
  public loading = false;
  hidrometroID: number;
  _filtroLista = '';
  _daterange: string;

  constructor(private route: ActivatedRoute,
    private toastr: ToastrService,
    private alertaService: AlertaService) {
    this.route.params.subscribe(params => this.hidrometroID = params.id);
  }

  get daterange() {
    return this._daterange;
  }

  set daterange(value: string) {
    this._daterange = value;
    this.alertasFiltrados = this._daterange ? this.filtrarPorPeriodo(this._daterange) : this.alertas;
  }

  get filtroLista(): string {
    return this._filtroLista;
  }
  set filtroLista(value: string) {
    this._filtroLista = value;
    this.alertasFiltrados = this.filtroLista ? this.filtraralertas(this.filtroLista) : this.alertas;
  }

  filtrarPorPeriodo(daterange: any) {
    this._filtroLista = '';
    return this.alertas.filter(x =>
      (new Date(x.data) >= new Date(daterange[0].toDateString())) &&
      (new Date(x.data) <= new Date(daterange[1].toDateString()))
    );
  }

  filtraralertas(filtrarPor: string): Alerta[] {
    this._daterange = '';
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.alertas.filter(x =>
      (x.id.toString().toLocaleLowerCase().indexOf(filtrarPor) !== -1) ||
      (x.descricao.toString().toLocaleLowerCase().indexOf(filtrarPor) !== -1) ||
      (x.descricaoRegra.toString().toLocaleLowerCase().indexOf(filtrarPor) !== -1) ||
      (x.regra.tipo.toString().toLocaleLowerCase().indexOf(filtrarPor) !== -1) ||
      (x.regra.valor.toString().toLocaleLowerCase().indexOf(filtrarPor) !== -1)
    );
  }

  limparFiltro(){
    this._daterange = '';
    this._filtroLista = '';
    this.alertasFiltrados = this.alertas;
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
        this.alertasFiltrados = _alertas;

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
