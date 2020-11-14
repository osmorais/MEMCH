import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { ToastrService } from 'ngx-toastr';
import { Conexao } from '../_models/Conexao';
import { Hidrometro } from '../_models/Hidrometro';
import { Pessoa } from '../_models/Pessoa';
import { Usuario } from '../_models/Usuario';
import { ConexaoService } from '../_services/conexao.service';
import { UsuarioService } from '../_services/Usuario.service';
import * as sha512 from 'js-sha512';

@Component({
  selector: 'app-Usuario',
  templateUrl: './Usuario.component.html',
  styleUrls: ['./Usuario.component.css']
})
export class UsuarioComponent implements OnInit {
  registerForm: FormGroup;
  registerFormConexao: FormGroup;
  modalRef: BsModalRef;
  public loading = false;
  currentUsuario: Usuario;
  currentConexao: Conexao;


  constructor(private usuarioService: UsuarioService,
    private fb: FormBuilder,
    private toastr: ToastrService,
    private conexaoService: ConexaoService,
    private modalService: BsModalService,
    public router: Router) { }

  ngOnInit() {
    this.validador();
    // this.validadorConexao();
  }

  validadorConexao() {
    this.registerFormConexao = this.fb.group({
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

  validador() {
    this.registerForm = this.fb.group({
      nome: ['', [Validators.required, Validators.minLength(10), Validators.maxLength(40)]],
      cpf: ['', [Validators.required, Validators.minLength(11), Validators.maxLength(11), this.ValidaCpf]],
      email: ['', [Validators.required, Validators.email]],
      usuario: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(15)]],
      passwords: this.fb.group({
        senha: ['', [Validators.required, Validators.minLength(5), Validators.maxLength(50)]],
        confirmarSenha: ['', [Validators.required, Validators.minLength(5), Validators.maxLength(50)]]
      }, { validator: this.compararSenhas })
    });
  }

  compararSenhas(fb: FormGroup) {
    if (fb.get('confirmarSenha').errors == null || 'mismatch' in fb.get('confirmarSenha').errors) {
      if (fb.get('senha').value !== fb.get('confirmarSenha').value) {
        fb.get('confirmarSenha').setErrors({ mismatch: true });
      } else {
        fb.get('confirmarSenha').setErrors(null);
      }
    }
  }

  ValidaCpf(controle: AbstractControl) {
    const cpf = controle.value;

    let soma: number = 0;
    let resto: number;
    let valido: boolean;

    const regex = new RegExp('[0-9]{11}');

    if (
      cpf == '00000000000' ||
      cpf == '11111111111' ||
      cpf == '22222222222' ||
      cpf == '33333333333' ||
      cpf == '44444444444' ||
      cpf == '55555555555' ||
      cpf == '66666666666' ||
      cpf == '77777777777' ||
      cpf == '88888888888' ||
      cpf == '99999999999' ||
      !regex.test(cpf)
    )
      valido = false;
    else {
      for (let i = 1; i <= 9; i++)
        soma = soma + parseInt(cpf.substring(i - 1, i)) * (11 - i);
      resto = (soma * 10) % 11;

      if (resto == 10 || resto == 11) resto = 0;
      if (resto != parseInt(cpf.substring(9, 10))) valido = false;

      soma = 0;
      for (let i = 1; i <= 10; i++)
        soma = soma + parseInt(cpf.substring(i - 1, i)) * (12 - i);
      resto = (soma * 10) % 11;

      if (resto == 10 || resto == 11) resto = 0;
      if (resto != parseInt(cpf.substring(10, 11))) valido = false;
      valido = true;
    }

    if (valido){ return null;}

    return { cpfInvalido: true };
  }

  cadastrarUsuario() {
    if (this.registerForm.valid) {
      this.currentUsuario = new Usuario();
      this.currentUsuario.login = this.registerForm.get('usuario').value;
      this.currentUsuario.senha = this.registerForm.get('passwords.senha').value;
      this.currentUsuario.email = this.registerForm.get('email').value;
      
      this.currentUsuario.senha = sha512.sha512(this.currentUsuario.senha).toLocaleUpperCase();

      this.currentUsuario.pessoa = new Pessoa();
      this.currentUsuario.pessoa.nome = this.registerForm.get('nome').value;
      this.currentUsuario.pessoa.cpf = this.registerForm.get('cpf').value;

      this.loading = true;

      this.usuarioService.postUsuario(this.currentUsuario).subscribe((_usuario: Usuario) => {
        this.toastr.success(`Usuario cadastrado com sucesso!`);
        setTimeout(() => {
          this.loading = false;
          // this.salvarConexao();
          this.router.navigate(['/login']);
        }, 1000);
      }, error => {
        this.loading = false;
        this.toastr.error('Erro ao tentar cadastrar');
        console.log(error);
      });
    }
    else {
      this.toastr.error('Verifique os campos informados e tente novamente.', 'Formulario invalido');
    }
  }

  voltarLogin() {
    this.loading = true;
    setTimeout(() => {
          this.loading = false;
          this.router.navigate(['/login']);
        }, 500);
  }

  criarConexao(template: any) {
    this.registerFormConexao.reset();
    this.registerFormConexao.get('ativo').setValue(false);
    this.registerFormConexao.get('hidrometroAtivo').setValue(false);
    this.openModal(template);
  }

  openModal(template: any) {
    this.modalRef = this.modalService.show(template);
  }

  // adicionarConexao(modal: any) {
  //   if (this.registerFormConexao.valid) {
  //     let currentForm = Object.assign({}, this.registerFormConexao.value);

  //     this.currentConexao = new Conexao();
  //     this.currentConexao.host = currentForm.host;
  //     this.currentConexao.ativo = currentForm.ativo;
  //     this.currentConexao.descricao = currentForm.descricao;

  //     this.currentConexao.hidrometro = new Hidrometro();
  //     this.currentConexao.hidrometro.chave = currentForm.chave;
  //     this.currentConexao.hidrometro.ativo = currentForm.hidrometroAtivo;
  //     this.currentConexao.hidrometro.descricao = currentForm.hidrometrodescricao;
  //     this.currentConexao.hidrometro.identificador = currentForm.identificador;
  //     this.currentConexao.hidrometro.modelo = currentForm.modelo;

  //     modal.hide();
  //   }
  // }

  // salvarConexao() {
  //   if (this.registerFormConexao.valid) {
  //     this.loading = true;

  //     this.conexaoService.postConexao(this.currentConexao).subscribe(
  //       (_novaconexao: Conexao) => {

  //         this.toastr.success(`Conexão cadastrada com sucesso!`);
  //         setTimeout(() => {
  //           this.loading = false;
  //           this.currentConexao = _novaconexao;
  //         }, 1000);
  //       }, error => {
  //         this.loading = false;
  //         this.toastr.error('Erro ao tentar cadastrar');
  //         console.log(error);
  //       }
  //     );
  //   }
  //   else {
  //     this.toastr.error('Verifique os campos informados e tente novamente.', 'Formulario invalido');
  //   }
  // }
  //   }
}
