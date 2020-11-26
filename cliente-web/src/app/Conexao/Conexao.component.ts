import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { ToastrService } from 'ngx-toastr';
import { Conexao } from '../_models/Conexao';
import { Hidrometro } from '../_models/Hidrometro';
import { ConexaoService } from '../_services/conexao.service';

@Component({
  selector: 'app-Conexao',
  templateUrl: './Conexao.component.html',
  styleUrls: ['./Conexao.component.css']
})
export class ConexaoComponent implements OnInit {
  registerForm: FormGroup;
  modalRef: BsModalRef;
  conexoes: Conexao[];
  conexoesFiltradas: Conexao[];
  currentId: number;
  currentHidrometroId: number;
  currentConexao: Conexao;
  public loading = false;
  modoSalvar = 'post';
  bodyDeletarConexao = '';
  _filtroLista = '';

  constructor(private route: ActivatedRoute,
    private modalService: BsModalService,
    private conexaoService: ConexaoService,
    private fb: FormBuilder,
    private toastr: ToastrService) { }

  get filtroLista(): string {
    return this._filtroLista;
  }
  set filtroLista(value: string) {
    this._filtroLista = value;
    this.conexoesFiltradas = this.filtroLista ? this.filtrarConexoes(this.filtroLista) : this.conexoes;
  }

  filtrarConexoes(filtrarPor: string): Conexao[] {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.conexoes.filter(x => 
      (x.id.toString().toLocaleLowerCase().indexOf(filtrarPor) !== -1) || 
      (x.descricao.toString().toLocaleLowerCase().indexOf(filtrarPor) !== -1) || 
      (x.host.toString().toLocaleLowerCase().indexOf(filtrarPor) !== -1) ||
      (x.hidrometro.chave.toString().toLocaleLowerCase().indexOf(filtrarPor) !== -1) || 
      (x.hidrometro.descricao.toString().toLocaleLowerCase().indexOf(filtrarPor) !== -1) || 
      (x.hidrometro.identificador.toString().toLocaleLowerCase().indexOf(filtrarPor) !== -1) || 
      (x.hidrometro.modelo.toString().toLocaleLowerCase().indexOf(filtrarPor) !== -1)
    );
  }

  ngOnInit() {
    this.validador();
    this.getConexoes();
  }

  openModal(template: any) {
    this.modalRef = this.modalService.show(template);
  }

  validador() {
    this.registerForm = this.fb.group({
      host: ['', [Validators.required, Validators.minLength(7), Validators.maxLength(15)]],
      ativo: ['',],
      descricao: ['', [Validators.required, Validators.minLength(4)]],
      identificador: ['', [Validators.required, Validators.minLength(4)]],
      chave: ['', [Validators.required, Validators.minLength(4)]],
      hidrometroAtivo: ['',],
      modelo: ['', [Validators.required, Validators.minLength(4)]],
      hidrometrodescricao: ['', [Validators.required, Validators.minLength(4)]]
    });
  }

  getConexoes() {
    this.loading = true;
    this.conexaoService.getConexoes().subscribe((_conexoes: Conexao[]) => {
      this.loading = false;

      this.conexoes = _conexoes;
      this.conexoesFiltradas = _conexoes;

      if (this.conexoes.length > 1) { this.toastr.info(this.conexoes.length + ' conexoes foram retornadas!'); }
      if (this.conexoes.length == 1) { this.toastr.info(this.conexoes.length + ' conexao foi retornada!'); }
      console.log(_conexoes);

    }, error => {
      this.loading = false;
      this.toastr.error('Não foi possível recuperar os dados.', 'Verifique sua conexão');
      console.log(error);
    })
  }

  criarConexao(template: any) {
    var self = this;
    this.modoSalvar = 'post';
    this.registerForm.reset();
    this.registerForm.get('ativo').setValue(false);
    this.registerForm.get('hidrometroAtivo').setValue(false);
    this.openModal(template);
  }

  editarConexao(currentConexao: Conexao, template: any) {
    var self = this;
    this.modoSalvar = 'put';
    this.currentConexao = Object.assign({}, currentConexao);
    this.currentId = this.currentConexao.id;
    this.currentHidrometroId = this.currentConexao.hidrometro.id;

    this.registerForm.get('host').setValue(currentConexao.host);
    this.registerForm.get('descricao').setValue(currentConexao.descricao);
    this.registerForm.get('ativo').setValue(currentConexao.ativo);

    this.registerForm.get('identificador').setValue(currentConexao.hidrometro.identificador);
    this.registerForm.get('chave').setValue(currentConexao.hidrometro.chave);
    this.registerForm.get('hidrometroAtivo').setValue(currentConexao.hidrometro.ativo);
    this.registerForm.get('modelo').setValue(currentConexao.hidrometro.modelo);
    this.registerForm.get('hidrometrodescricao').setValue(currentConexao.hidrometro.descricao);
    this.openModal(template);
  }

  excluirConexao(currentConexao: Conexao, template: any) {
    var self = this;
    this.openModal(template);
    this.currentConexao = currentConexao;
    this.bodyDeletarConexao = `Tem certeza que deseja excluir a Conexao ${currentConexao.id}?`;
  }

  confirmeDelete(template: any, modal: any) {
    this.loading = true;

    this.conexaoService.deleteConexao(this.currentConexao.id).subscribe(
      () => {
        this.toastr.success('Conexão deletada com sucesso!');
        setTimeout(() => {
          this.loading = false;
          this.conexoes = [];
          this.getConexoes();
          modal.hide();
        }, 1000);

      }, error => {
        this.loading = false;
        this.toastr.error('Erro ao tentar deletar');
        console.log(error);

      }
    );
  }

  salvarAlteracao(template: any, modal: any) {
    var self = this;

    if (this.registerForm.valid) {

      let currentForm = Object.assign({}, this.registerForm.value);

      this.currentConexao = new Conexao();
      this.currentConexao.host = currentForm.host;
      this.currentConexao.ativo = currentForm.ativo;
      this.currentConexao.descricao = currentForm.descricao;

      this.currentConexao.hidrometro = new Hidrometro();
      this.currentConexao.hidrometro.chave = currentForm.chave;
      this.currentConexao.hidrometro.ativo = currentForm.hidrometroAtivo;
      this.currentConexao.hidrometro.descricao = currentForm.hidrometrodescricao;
      this.currentConexao.hidrometro.identificador = currentForm.identificador;
      this.currentConexao.hidrometro.modelo = currentForm.modelo;

      if (this.modoSalvar === 'post') {

        this.loading = true;

        this.conexaoService.postConexao(this.currentConexao).subscribe(
          (_novaconexao: Conexao) => {

            this.toastr.success(`Conexão cadastrada com sucesso!`);
            setTimeout(() => {
              this.loading = false;
              this.conexoes = [];
              this.getConexoes();
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

        this.currentConexao.id = this.currentId;
        this.currentConexao.hidrometro.id = this.currentHidrometroId;

        this.loading = true;

        this.conexaoService.putConexao(this.currentConexao).subscribe(
          (_conexao: Conexao) => {

            this.toastr.success(`Conexão alterada com sucesso!`);
            setTimeout(() => {
              this.loading = false;
              this.conexoes = [];
              this.getConexoes();
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
    else {
      this.toastr.error('Verifique os campos informados e tente novamente.', 'Formulario invalido');
    }
  }
}
