import { Component, OnInit } from '@angular/core';
import { HidrometroService } from '../_services/hidrometro.service';
import { Hidrometro } from '../_models/Hidrometro';

@Component({
  // tslint:disable-next-line: component-selector
  selector: 'app-Menu',
  templateUrl: './Menu.component.html',
  styleUrls: ['./Menu.component.css']
})
export class MenuComponent implements OnInit {
  hidrometros: Hidrometro[];

  constructor(private hidrometroService: HidrometroService) { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
    this.getHidrometro();
  }

  // tslint:disable-next-line: typedef
  getHidrometro(){
    // tslint:disable-next-line: variable-name
    this.hidrometroService.getAllHidrometro().subscribe((_hidrometros: Hidrometro[]) => {
      this.hidrometros = _hidrometros;
      console.log(_hidrometros);
    },
      error => {
        console.log(error);
    });
  }
}
