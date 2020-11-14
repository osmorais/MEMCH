import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import * as sha512 from 'js-sha512';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { ToastrService } from 'ngx-toastr';
import { Conexao } from '../_models/Conexao';
import { Hidrometro } from '../_models/Hidrometro';
import { Pessoa } from '../_models/Pessoa';
import { Usuario } from '../_models/Usuario';
import { ConexaoService } from '../_services/conexao.service';
import { HidrometroService } from '../_services/hidrometro.service';
import { UsuarioService } from '../_services/Usuario.service';

@Component({
  selector: 'app-Dashboard',
  templateUrl: './Dashboard.component.html',
  styleUrls: ['./Dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  public loading = false;
  hidrometros: Array<Hidrometro>;
  conexoes: Conexao[];
  registerForm: FormGroup;
  currentUsuario: Usuario;
  modalRef: BsModalRef;

  constructor(private conexaoService: ConexaoService,
    private toastr: ToastrService,
    private fb: FormBuilder,
    private hidrometroService: HidrometroService,
    private usuarioService: UsuarioService,
    private modalService: BsModalService,
    public router: Router) { }

  ngOnInit() {
    this.getConexoes();
    this.validador();
  }

  validador() {
    this.registerForm = this.fb.group({
      nome: ['', [Validators.required, Validators.minLength(10), Validators.maxLength(40)]],
      cpf: ['', [Validators.required, Validators.minLength(11), Validators.maxLength(14)]],
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

  getConexoes() {
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

  // getHidrometros() {
  //   this.loading = true;
  //   this.hidrometroService.getAllHidrometro(localStorage.getItem('host')).subscribe((_hidrometros: Array<Hidrometro>) => {
  //     this.loading = false;
  //     this.hidrometros = _hidrometros;
  //     this.toastr.info('Dados recuperados com sucesso');
  //     console.log(_hidrometros);
  //   },
  //     error => {
  //       this.loading = false;
  //       this.toastr.error('Por favor verifique sua conexão', 'Falha de comunicação');
  //       console.log();
  //     });
  // }

  OpenPage(redirectString: String, hidrometroId: number) {
    this.redirectTo('/' + redirectString + '/' + hidrometroId);
  }

  redirectTo(uri: string) {
    this.router.navigateByUrl('/#', { skipLocationChange: true }).then(() =>
      this.router.navigate([uri]));
  }

  alterarUsuario(template: any) {
    this.registerForm.reset();
    this.currentUsuario = new Usuario();
    this.currentUsuario.id = parseInt(localStorage.getItem('currentUsuarioID'));

    this.loading = true;
    this.usuarioService.getUsuario(this.currentUsuario.id).subscribe((_usuario: Usuario) => {
      this.currentUsuario = _usuario;

      this.loading = false;
    
      this.registerForm.get('nome').setValue(this.currentUsuario.pessoa.nome);
      this.registerForm.get('cpf').setValue(this.currentUsuario.pessoa.cpf);
      this.registerForm.get('email').setValue(this.currentUsuario.email);
      this.registerForm.get('usuario').setValue(this.currentUsuario.login);

      this.openModal(template);
    }, error => {
      this.loading = false;
      this.toastr.error('Erro ao tentar recuperar o usuario');
      console.log(error);
    });
  }

  openModal(template: any) {
    this.modalRef = this.modalService.show(template);
  }

  salvarAlteracao(template: any, modal: any) {
    if (this.registerForm.valid) {
      this.currentUsuario.login = this.registerForm.get('usuario').value;
      this.currentUsuario.senha = this.registerForm.get('passwords.senha').value;
      this.currentUsuario.email = this.registerForm.get('email').value;
      
      this.currentUsuario.senha = sha512.sha512(this.currentUsuario.senha).toLocaleUpperCase();

      this.currentUsuario.pessoa = new Pessoa();
      this.currentUsuario.pessoa.nome = this.registerForm.get('nome').value;
      this.currentUsuario.pessoa.cpf = this.registerForm.get('cpf').value;

      this.loading = true;

      this.usuarioService.putUsuario(this.currentUsuario).subscribe((_usuario: Usuario) => {
        this.toastr.success(`Usuario alterado com sucesso!`);
        setTimeout(() => {
          this.loading = false;
          modal.hide();
        }, 1000);
      }, error => {
        this.loading = false;
        this.toastr.error('Erro ao tentar alterar');
        console.log(error);
      });
    }
    else {
      this.toastr.warning('Verifique os campos informados e tente novamente.', 'Formulario invalido');
    }
  }
}
