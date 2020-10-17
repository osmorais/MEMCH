import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Regra } from 'src/app/_models/Regra';
import { RegraService } from 'src/app/_services/regra.service';
import { ToastrService } from 'ngx-toastr';
import { ActivatedRoute } from '@angular/router';
import { RegratipoService } from '../_services/regratipo.service';
import { RegraTipo } from '../_models/RegraTipo';

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
  regraTipos: RegraTipo[];
  hidrometroID: number;
  public loading = false;

  constructor(private route: ActivatedRoute,
              private modalService: BsModalService,
              private regraService: RegraService,
              private regraTipoService: RegratipoService,
              private toastr: ToastrService) {
                this.route.params.subscribe(params => this.hidrometroID = params.id);
              }

  // tslint:disable-next-line: typedef
  ngOnInit() {
    // tslint:disable-next-line: no-var-keyword prefer-const
    var self = this;
    this.getRegras();
    this.getRegraTipo();
  }

  // tslint:disable-next-line: typedef
  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  // tslint:disable-next-line: typedef
  getRegraTipo() {
    // tslint:disable-next-line: variable-name
    this.regraTipoService.getAllRegraTipo().subscribe((_regraTipos: RegraTipo[]) => {
      this.regraTipos = _regraTipos;
      console.log(this.regraTipos);
    }, error => {
      this.toastr.error('Não foi possível recuperar os dados da(s) regra(s).', 'Verifique sua conexão');
      console.log(error);
    });
  }

  // tslint:disable-next-line: typedef
  getRegras() {
    // tslint:disable-next-line: variable-name
    this.regraService.getRegras(this.hidrometroID).subscribe((_regras: Regra[]) => {
      this.regras = _regras;
      if (this.regras.length > 1) { this.toastr.info(this.regras.length + ' regras foram retornadas!'); }
      // tslint:disable-next-line: triple-equals
      if (this.regras.length == 1) { this.toastr.info(this.regras.length + ' regra foi retornada!'); }
      console.log(_regras);
    }, error => {
      this.toastr.error('Não foi possível recuperar os dados da(s) regra(s).', 'Verifique sua conexão');
      console.log(error);
    });
  }

  // tslint:disable-next-line: typedef
  salvarAlteracao() {
    console.log(this.registerForm.value);
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
