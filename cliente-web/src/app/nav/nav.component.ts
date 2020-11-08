import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../_services/Auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss']
})
export class NavComponent implements OnInit {

  constructor(private authService: AuthService,
              private router: Router) { }

  ngOnInit() {
  }

  LogOut(){
    this.authService.desautenticarUsuario();
    this.router.navigate(['/login'])
  }

  LoggedIn(){
    return this.authService.usuarioAutenticado;
  }
}
