import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AlertaComponent } from './Alerta/Alerta.component';
import { ConexaoComponent } from './Conexao/Conexao.component';
import { DashboardComponent } from './Dashboard/Dashboard.component';
import { LoginComponent } from './Login/Login.component';
import { RegistrosComponent } from './Registros/Registros.component';
import { RegraComponent } from './Regra/regra.component';
import { UsuarioComponent } from './Usuario/Usuario.component';
import { AuthGuard } from './_guards/Auth.Guard';

const routes: Routes = [
  {path: 'login', component: LoginComponent},
  {path: 'cadastrar', component: UsuarioComponent},
  {path: 'registros/:id', component: RegistrosComponent, canActivate: [AuthGuard]},
  {path: 'regras/:id', component: RegraComponent, canActivate: [AuthGuard]},
  {path: 'alertas/:id', component: AlertaComponent, canActivate: [AuthGuard]},
  {path: 'dashboard', component: DashboardComponent, canActivate: [AuthGuard]},
  {path: 'conexao', component: ConexaoComponent, canActivate: [AuthGuard]},
  {path: '#', component: DashboardComponent, canActivate: [AuthGuard]},
  {path: '', redirectTo: 'login', pathMatch: 'full'},
  {path: '**', redirectTo: 'login', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
