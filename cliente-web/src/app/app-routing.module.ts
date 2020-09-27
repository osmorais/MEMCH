import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AlertaComponent } from './Alerta/Alerta.component';
import { DashboardComponent } from './Dashboard/Dashboard.component';
import { LoginComponent } from './Login/Login.component';
import { RegistrosComponent } from './Registros/Registros.component';
import { RegraComponent } from './Regra/regra.component';

const routes: Routes = [
  {path: 'login', component: LoginComponent},
  {path: 'registros/:id', component: RegistrosComponent},
  {path: 'regras/:id', component: RegraComponent},
  {path: 'alertas/:id', component: AlertaComponent},
  {path: 'dashboard', component: DashboardComponent},
  {path: '#', component: DashboardComponent},
  {path: '', redirectTo: 'login', pathMatch: 'full'},
  {path: '**', redirectTo: 'login', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
