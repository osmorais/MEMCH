import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  // tslint:disable-next-line: component-selector
  selector: 'app-Regra',
  templateUrl: './regra.component.html',
  styleUrls: ['./regra.component.css']
})
export class RegraComponent implements OnInit {
  registerForm: FormGroup;
  modalRef: BsModalRef;

  constructor(private modalService: BsModalService) { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
  }

  // tslint:disable-next-line: typedef
  openModal(template: TemplateRef<any>){
    this.modalRef = this.modalService.show(template);
  }

  // tslint:disable-next-line: typedef
  salvarAlteracao(){

  }

  // tslint:disable-next-line: typedef
  validation(){
    this.registerForm = new FormGroup({
      valor: new FormControl('', [Validators.required, Validators.minLength(4), Validators.maxLength(50)]),
      periodo: new FormControl('', Validators.required),
      tipo: new FormControl('', Validators.required),
      ativo: new FormControl()
    });
  }
}
