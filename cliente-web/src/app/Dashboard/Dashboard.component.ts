import { Component, OnInit, ViewChild } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
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
import { ChartDataSets, ChartOptions, ChartType } from 'chart.js';
import { Color, BaseChartDirective, Label } from 'ng2-charts';

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
  currentPessoaID: number;
  public lineChartData: ChartDataSets[] = [];

  // { data: [65, 59, 80, 81, 56, 55, 40], label: 'Hidrometro 1' }

  public lineChartLabels: Label[] = ['Jan', 'Fev', 'Mar', 'Abr', 'Mai', 'Jun', 'Jul', 'Ago', 'Set', 'Out', 'Nov', 'Dez'];
  public lineChartOptions: (ChartOptions & { annotation: any }) = {
    responsive: false,
    scales: {
      // We use this empty structure as a placeholder for dynamic theming.
      xAxes: [{}],
      yAxes: [
        {
          id: 'y-axis-0',
          position: 'left',
        },
        {
          id: 'y-axis-1',
          position: 'right',
          gridLines: {
            color: 'rgba(255,0,0,0.3)',
          },
          ticks: {
            fontColor: 'red',
          }
        }
      ]
    },
    annotation: {},
  };
  public lineChartColors: Color[] = [
    { // grey
      backgroundColor: 'rgba(148,159,177,0.2)',
      borderColor: 'rgba(148,159,177,1)',
      pointBackgroundColor: 'rgba(148,159,177,1)',
      pointBorderColor: '#fff',
      pointHoverBackgroundColor: '#fff',
      pointHoverBorderColor: 'rgba(148,159,177,0.8)'
    },
    { // dark grey
      backgroundColor: 'rgba(77,83,96,0.2)',
      borderColor: 'rgba(77,83,96,1)',
      pointBackgroundColor: 'rgba(77,83,96,1)',
      pointBorderColor: '#fff',
      pointHoverBackgroundColor: '#fff',
      pointHoverBorderColor: 'rgba(77,83,96,1)'
    },
    { // green
      backgroundColor: 'rgba(0, 255, 0, 0.3)',
      borderColor: 'green',
      pointBackgroundColor: 'rgba(148,159,177,1)',
      pointBorderColor: '#fff',
      pointHoverBackgroundColor: '#fff',
      pointHoverBorderColor: 'rgba(148,159,177,0.8)'
    },
    { // red
      backgroundColor: 'rgba(255,0,0,0.3)',
      borderColor: 'red',
      pointBackgroundColor: 'rgba(148,159,177,1)',
      pointBorderColor: '#fff',
      pointHoverBackgroundColor: '#fff',
      pointHoverBorderColor: 'rgba(148,159,177,0.8)'
    }
  ];
  public lineChartLegend = true;
  public lineChartType: ChartType = 'line';

  @ViewChild(BaseChartDirective, { static: true }) chart: BaseChartDirective;

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

  // events
  public chartClicked({ event, active }: { event: MouseEvent, active: {}[] }): void {
    console.log(event, active);
  }

  public chartHovered({ event, active }: { event: MouseEvent, active: {}[] }): void {
    console.log(event, active);
  }

  validador() {
    this.registerForm = this.fb.group({
      nome: ['', [Validators.required, Validators.minLength(10), Validators.maxLength(40), this.somenteLetras]],
      cpf: ['', [Validators.required, Validators.minLength(11), Validators.maxLength(11), this.ValidaCpf]],
      email: ['', [Validators.required, Validators.email]],
      usuario: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(15)]],
      passwords: this.fb.group({
        senha: ['', [Validators.required, Validators.minLength(5), Validators.maxLength(50)]],
        confirmarSenha: ['', [Validators.required, Validators.minLength(5), Validators.maxLength(50)]]
      }, { validator: this.compararSenhas })
    });
  }

  somenteLetras(controle: AbstractControl) {
    var stringvalue = controle.value;

    if (stringvalue == null) {
      return null
    }

    if (stringvalue.indexOf("1") > -1 ||
      stringvalue.indexOf("2") > -1 ||
      stringvalue.indexOf("3") > -1 ||
      stringvalue.indexOf("4") > -1 ||
      stringvalue.indexOf("5") > -1 ||
      stringvalue.indexOf("6") > -1 ||
      stringvalue.indexOf("7") > -1 ||
      stringvalue.indexOf("8") > -1 ||
      stringvalue.indexOf("9") > -1) {
      return { contemNumeros: true };
    }

    return null;
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

    if (valido) { return null; }

    return { cpfInvalido: true };
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

      this.conexoes.forEach(x => {
        var registros = x.hidrometro.registros;

        this.lineChartData.push(
          {
            data: [
              +registros[0].valor,
              +registros[1].valor,
              +registros[2].valor,
              +registros[3].valor, 
              +registros[4].valor, 
              +registros[5].valor, 
              +registros[6].valor, 
              +registros[7].valor,
              +registros[8].valor,
              +registros[9].valor, 
              +registros[10].valor, 
              +registros[11].valor
            ], 
              label: x.hidrometro.identificador
          })
      });


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
      this.currentPessoaID = this.currentUsuario.pessoa.id;
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
      this.currentUsuario.pessoa.id = this.currentPessoaID;
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
