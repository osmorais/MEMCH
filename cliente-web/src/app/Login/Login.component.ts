import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { Usuario } from '../_models/Usuario';
import { UsuarioService } from '../_services/Usuario.service';
import { ToastrService } from 'ngx-toastr';
import { Router, RouterLink } from '@angular/router';

@Component({
  selector: 'app-Login',
  templateUrl: './Login.component.html',
  styleUrls: ['./Login.component.css']
})
export class LoginComponent implements OnInit {
  registerForm: FormGroup;
  usuario: Usuario;
  succes: boolean;
  public loading = false;

  constructor(private usuarioService: UsuarioService,
              private fb: FormBuilder,
              private toastr: ToastrService,
              public router: Router) { }

  ngOnInit() {
    this.validation();
  }

  validation() {
    this.registerForm = this.fb.group({
      login: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(20)]],
      senha: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(20)]],
    });
  }

  fazerLogin() {
    this.loading = true;
    if (this.registerForm.valid) {
      this.usuario = Object.assign({}, this.registerForm.value);
      this.usuarioService.postDoLogin(this.usuario).subscribe(
        (usuarioResponse: Usuario) => {
          this.loading = false;
          if (usuarioResponse.id != null && usuarioResponse.id != 0){
            this.router.navigate(['/dashboard']);
            this.toastr.success('Autenticação feita com sucesso!'); }
          else { this.toastr.warning('Usuario não encontrado, verifique seus dados de acesso!'); }
          console.log(usuarioResponse);
        }, error => {
          this.loading = false;
          this.toastr.error('Por favor verifique sua conexão', 'Falha de comunicação');
          console.log(error);
        }
      );
    }
  }
}
