import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { Conexao } from '../_models/Conexao';
import { ConexaoService } from '../_services/conexao.service';

@Component({
  // tslint:disable-next-line: component-selector
  selector: 'app-Menu',
  templateUrl: './Menu.component.html',
  styleUrls: ['./Menu.component.css']
})
export class MenuComponent implements OnInit {
  conexoes: Conexao[];
  openSecondLevel: boolean;
  redirectString: string;
  public loading = false;

  constructor(private conexaoService: ConexaoService,
              private toastr: ToastrService,
              public router: Router) { }

  ngOnInit() {
    //this.getConexoes();
    this.openSecondLevel = false;
  }

  OpenSecondLevel(redirect: string){
    this.getConexoes();
    this.redirectString = redirect;
    this.openSecondLevel = true;
  }

  CloseSecondLevel(){
    this.openSecondLevel = false;
  }

  OpenPage(hidrometroId: number, host: string){
    localStorage.setItem('host', host);
    this.redirectTo('/' + this.redirectString + '/' + hidrometroId);
  }

  redirectTo(uri: string){
    this.router.navigateByUrl('/#', {skipLocationChange: true}).then(() =>
    this.router.navigate([uri]));
 }

 getConexoes(){
   this.loading = true;
  this.conexaoService.getConexoes().subscribe((_conexoes: Conexao[]) => {
    this.loading = false;
    this.conexoes = _conexoes;
    console.log(_conexoes);

  }, error => {
    this.loading = false;
    this.toastr.error('Não foi possível recuperar os dados.', 'Verifique sua conexão');
    console.log(error);
  })
}
}
