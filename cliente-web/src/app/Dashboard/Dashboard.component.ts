import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Hidrometro } from '../_models/Hidrometro';
import { HidrometroService } from '../_services/hidrometro.service';

@Component({
  selector: 'app-Dashboard',
  templateUrl: './Dashboard.component.html',
  styleUrls: ['./Dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  public loading = false;
  hidrometros: Array<Hidrometro>;

  constructor(private toastr: ToastrService,
              private hidrometroService: HidrometroService,
              public router: Router) { }

  ngOnInit() {
    this.getHidrometros();
  }

  getHidrometros() {
    this.loading = true;
    this.hidrometroService.getAllHidrometro(localStorage.getItem('host')).subscribe((_hidrometros: Array<Hidrometro>) => {
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

  OpenPage(redirectString: String, hidrometroId: number){
    this.redirectTo('/' + redirectString + '/' + hidrometroId);
  }

  redirectTo(uri: string){
    this.router.navigateByUrl('/#', {skipLocationChange: true}).then(() =>
    this.router.navigate([uri]));
 }
}
