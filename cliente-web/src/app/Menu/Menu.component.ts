import { Component, OnInit } from '@angular/core';
import { HidrometroService } from '../_services/hidrometro.service';
import { Hidrometro } from '../_models/Hidrometro';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';

@Component({
  // tslint:disable-next-line: component-selector
  selector: 'app-Menu',
  templateUrl: './Menu.component.html',
  styleUrls: ['./Menu.component.css']
})
export class MenuComponent implements OnInit {
  hidrometros: Hidrometro[];
  openSecondLevel: boolean;
  redirectString: string;

  constructor(private hidrometroService: HidrometroService,
              private toastr: ToastrService,
              public router: Router) { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
    this.getHidrometro();
    this.openSecondLevel = false;
  }

  // tslint:disable-next-line: typedef
  getHidrometro(){
    // tslint:disable-next-line: variable-name
    this.hidrometroService.getAllHidrometro().subscribe((_hidrometros: Hidrometro[]) => {
      this.hidrometros = _hidrometros;
      console.log(_hidrometros);
    },
      error => {
        this.toastr.error('Não foi possível recuperar os dados do hidrometro.', 'Verifique sua conexão');
        console.log(error);
    });
  }

  // tslint:disable-next-line: typedef
  OpenSecondLevel(redirect: string){
    this.redirectString = redirect;
    this.openSecondLevel = true;
  }

  // tslint:disable-next-line: typedef
  CloseSecondLevel(){
    this.openSecondLevel = false;
  }

  // tslint:disable-next-line: typedef
  OpenPage(id: number){
    this.redirectTo('/' + this.redirectString + '/' + id);
  }

  // tslint:disable-next-line: typedef
  redirectTo(uri: string){
    this.router.navigateByUrl('/#', {skipLocationChange: true}).then(() =>
    this.router.navigate([uri]));
 }
}
