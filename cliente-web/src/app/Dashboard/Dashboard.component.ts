import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Hidrometro } from '../_models/Hidrometro';
import { HidrometroService } from '../_services/hidrometro.service';

@Component({
  // tslint:disable-next-line: component-selector
  selector: 'app-Dashboard',
  templateUrl: './Dashboard.component.html',
  styleUrls: ['./Dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  public loading = false;
  hidrometros: Array<Hidrometro>;

  constructor(private toastr: ToastrService,
              private hidrometroService: HidrometroService) { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
    this.getHidrometros();
  }

  // tslint:disable-next-line: typedef
  getHidrometros() {
    this.loading = true;
    // tslint:disable-next-line: variable-name
    this.hidrometroService.getAllHidrometro().subscribe((_hidrometros: Array<Hidrometro>) => {
      this.loading = false;
      this.hidrometros = _hidrometros;
      this.toastr.info('Dados recuperados com sucesso');
      console.log(_hidrometros);
    },
      error => {
        this.loading = false;
        this.toastr.error('Por favor verifique sua conexão', 'Falha de comunicação');
        console.log();
      });
  }
}
