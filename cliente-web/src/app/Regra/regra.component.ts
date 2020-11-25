import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { Regra } from 'src/app/_models/Regra';
import { RegraService } from 'src/app/_services/regra.service';
import { ToastrService } from 'ngx-toastr';
import { ActivatedRoute } from '@angular/router';
import { RegratipoService } from '../_services/regratipo.service';
import { RegraTipo } from '../_models/RegraTipo';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';

@Component({
  selector: 'app-Regra',
  templateUrl: './regra.component.html',
  styleUrls: ['./regra.component.css']
})
export class RegraComponent implements OnInit {
  registerForm: FormGroup;
  modalRef: BsModalRef;
  regras: Regra[];
  currentId: number;
  currentRegra: Regra;
  regraTipos: RegraTipo[];
  hidrometroID: number;
  public loading = false;
  bodyDeletarRegra = '';
  modoSalvar = 'post';

  tiposList: RegraTipo[] = [
    { id: 1, descricao: 'Surto' },
    { id: 2, descricao: 'Consumo' }
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
    this.regraTipoService.getAllRegraTipo(localStorage.getItem('host')).subscribe((_regraTipos: RegraTipo[]) => {

      this.regraTipos = _regraTipos;

    }, error => {

      this.toastr.error('Não foi possível recuperar os dados da(s) regra(s).', 'Verifique sua conexão');
      console.log(error);

    });
  }

  getRegras() {
    this.loading = true;
    this.regraService.getRegras(this.hidrometroID, localStorage.getItem('host'))
    .subscribe((_regras: Regra[]) => {
      this.loading = false;
      this.regras = _regras;

      if (this.regras.length > 1) { this.toastr.info(this.regras.length + ' regras foram retornadas!'); }
      if (this.regras.length == 1) { this.toastr.info(this.regras.length + ' regra foi retornada!'); }

    }, error => {

      this.loading = false;
      this.toastr.error('Não foi possível recuperar os dados da(s) regra(s).', 'Verifique sua conexão');
      console.log(error);

    });
  }

  salvarAlteracao(template: any, modal: any) {
    var self = this;
    this.registerForm.get('tipo').setValue(
      this.regraTipos.find(x => x.descricao.toLocaleUpperCase() == this.registerForm.get('tipo').value.toLocaleUpperCase()));

    if (this.registerForm.valid) {

      this.currentRegra = Object.assign({}, this.registerForm.value);

      if (this.modoSalvar === 'post') {

        this.loading = true;

        this.regraService.postRegra(this.hidrometroID, localStorage.getItem('host'), this.currentRegra)
        .subscribe(
          (novaRegra: Regra) => {

            this.toastr.success(`Regra cadastrada com sucesso!`);
            setTimeout(() => {
              this.loading = false;
              this.regras = [];
              this.getRegras();
              modal.hide();
            }, 1000);

          }, error => {
            this.loading = false;
            this.toastr.error('Erro ao tentar cadastrar');
            console.log(error);
          }
        );
      }
      else {
        this.currentRegra.id = this.currentId;

        this.loading = true;

        this.regraService.putRegra(this.hidrometroID, localStorage.getItem('host'), this.currentRegra)
        .subscribe(
          (novaRegra: Regra) => {

            this.toastr.success(`Regra alterada com sucesso!`);
            setTimeout(() => {
              this.loading = false;
              this.regras = [];
              this.getRegras();
              modal.hide();
            }, 1000); 

          }, error => {
            this.loading = false;
            this.toastr.error('Erro ao tentar alterar');
            console.log(error);
          }
        );
      }
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

  criarRegra(tipos: RegraTipo[], template: any) {
    var self = this;
    this.modoSalvar = 'post';
    this.regraTipos = tipos;
    this.registerForm.reset();
    this.registerForm.get('ativo').setValue(false);
    this.registerForm.get('tipo').setValue(this.regraTipos[0].descricao);
    this.openModal(template);
  }

  editarRegra(currentRegra: Regra, template: any) {
    var self = this;
    this.modoSalvar = 'put';
    this.currentRegra = Object.assign({}, currentRegra);
    this.currentId = this.currentRegra.id;
    this.registerForm.get('valor').setValue(currentRegra.valor);
    this.registerForm.get('periodo').setValue(currentRegra.periodo);
    this.registerForm.get('tipo').setValue(currentRegra.tipo.descricao);
    this.registerForm.get('ativo').setValue(currentRegra.ativo);
    this.openModal(template);
  }

  excluirRegra(currentRegra: Regra, template: any) {
    var self = this;
    this.openModal(template);
    this.currentRegra = currentRegra;
    this.bodyDeletarRegra = `Tem certeza que deseja excluir a Regra ${currentRegra.id}?`;
  }

  confirmeDelete(template: any, modal: any) {
    this.loading = true;

    this.regraService.deleteRegra(this.currentRegra.id, localStorage.getItem('host'))
    .subscribe(
      () => {
        this.toastr.success('Regra deletada com sucesso!');
        setTimeout(() => {
          this.loading = false;
          this.regras = [];
          this.getRegras();
          modal.hide();
        }, 1000);

      }, error => {
        this.loading = false;
        this.toastr.error('Erro ao tentar deletar');
        console.log(error);

      }
    );
  }
}
