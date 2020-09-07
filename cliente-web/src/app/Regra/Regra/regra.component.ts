import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Regra } from 'src/app/_models/Regra';
import { RegraService } from 'src/app/_services/regra.service';

@Component({
  // tslint:disable-next-line: component-selector
  selector: 'app-Regra',
  templateUrl: './regra.component.html',
  styleUrls: ['./regra.component.css']
})
export class RegraComponent implements OnInit {
  registerForm: FormGroup;
  modalRef: BsModalRef;
  regras: Regra[];

  constructor(private modalService: BsModalService
    ,         private regraService: RegraService) { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
    this.getRegras();
  }

  // tslint:disable-next-line: typedef
  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  // tslint:disable-next-line: typedef
  getRegras() {
    // tslint:disable-next-line: variable-name
    this.regraService.getRegrasByHidrometro(12).subscribe((_regras: Regra[]) => {
      this.regras = _regras;
      console.log(_regras);
    }, error => {
      console.log(error);
    });
  }

  // tslint:disable-next-line: typedef
  salvarAlteracao() {

  }

  // tslint:disable-next-line: typedef
  validation() {
    this.registerForm = new FormGroup({
      valor: new FormControl('', [Validators.required, Validators.minLength(4), Validators.maxLength(50)]),
      periodo: new FormControl('', Validators.required),
      tipo: new FormControl('', Validators.required),
      ativo: new FormControl()
    });
  }
}
