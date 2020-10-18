import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { Regra } from 'src/app/_models/Regra';
import { RegraService } from 'src/app/_services/regra.service';
import { ToastrService } from 'ngx-toastr';
import { ActivatedRoute } from '@angular/router';
import { RegratipoService } from '../_services/regratipo.service';
import { RegraTipo } from '../_models/RegraTipo';

@Component({
  selector: 'app-Regra',
  templateUrl: './regra.component.html',
  styleUrls: ['./regra.component.css']
})
export class RegraComponent implements OnInit {
  registerForm: FormGroup;
  modalRef: BsModalRef;
  regras: Regra[];
  currentRegra: Regra;
  regraTipos: RegraTipo[];
  hidrometroID: number;
  public loading = false;
  bodyDeletarRegra = '';

  tiposList: RegraTipo[] = [
    {id: 1, descricao: 'Surto'},
    {id: 2, descricao: 'Consumo'}
  ];

  constructor(private route: ActivatedRoute,
              private modalService: BsModalService,
              private regraService: RegraService,
              private fb: FormBuilder,
              private regraTipoService: RegratipoService,
              private toastr: ToastrService) {
                this.route.params.subscribe(params => this.hidrometroID = params.id);
              }

  ngOnInit() {
    var self = this;
    this.validador();
    this.getRegras();
    this.regraTipos = this.tiposList;
    // this.getRegraTipo();
  }

  openModal(template: any) {
    this.modalRef = this.modalService.show(template);
  }

  getRegraTipo() {
    this.regraTipoService.getAllRegraTipo().subscribe((_regraTipos: RegraTipo[]) => {
      this.regraTipos = _regraTipos;
      console.log(this.regraTipos);
    }, error => {
      this.toastr.error('Não foi possível recuperar os dados da(s) regra(s).', 'Verifique sua conexão');
      console.log(error);
    });
  }

  getRegras() {
    this.loading = true;
    this.regraService.getRegras(this.hidrometroID).subscribe((_regras: Regra[]) => {
      this.loading = false;
      this.regras = _regras;
      if (this.regras.length > 1) { this.toastr.info(this.regras.length + ' regras foram retornadas!'); }
      if (this.regras.length == 1) { this.toastr.info(this.regras.length + ' regra foi retornada!'); }
      console.log(_regras);
    }, error => {
      this.loading = false;
      this.toastr.error('Não foi possível recuperar os dados da(s) regra(s).', 'Verifique sua conexão');
      console.log(error);
    });
  }

  salvarAlteracao(template: any) {
    var self = this;
    this.registerForm.get('tipo').setValue(this.regraTipos.find(x=> x.id == this.registerForm.get('tipo').value));
    if(this.registerForm.valid){
      
      this.modalRef.hide();
    }
  }

  validador() {
    this.registerForm = this.fb.group({
      valor: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(10)]],
      periodo: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(4)]],
      tipo: ['', [Validators.required]],
      ativo: []
    });
  }

  criarRegra(tipos: RegraTipo[],template: any) {
    var self = this;
    this.registerForm.get('ativo').setValue(false);
    this.openModal(template);
    this.regraTipos = tipos;
  }

  excluirRegra(currentRegra: Regra, template: any) {
    var self = this;
    this.openModal(template);
    this.currentRegra = currentRegra;
    this.bodyDeletarRegra = `Tem certeza que deseja excluir a Regra ${currentRegra.id}?`;
  }

  confirmeDelete(template: any) {
    this.loading = true;
    this.regraService.deleteRegra(this.currentRegra.id).subscribe(
      () => {
        this.toastr.success('Regra deletada com sucesso!');
        setTimeout(() => {
          this.loading = false;
          window.location.reload();
        }, 1000);
      }, error => {
        this.loading = false;
        this.toastr.error('Erro ao tentar deletar');
        console.log(error);
      }
    );
  }
}
