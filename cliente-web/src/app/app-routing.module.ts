import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AlertaComponent } from './Alerta/Alerta.component';
import { DashboardComponent } from './Dashboard/Dashboard.component';
import { LoginComponent } from './Login/Login.component';
import { RegistrosComponent } from './Registros/Registros.component';
import { RegraComponent } from './Regra/Regra/regra.component';

const routes: Routes = [
  {path: 'registros', component: RegistrosComponent},
  {path: 'regras', component: RegraComponent},
  {path: 'alertas', component: AlertaComponent},
  {path: 'login', component: LoginComponent},
  {path: 'dashboard', component: DashboardComponent},
  {path: '', redirectTo: 'registros', pathMatch: 'full'},
  {path: '**', redirectTo: 'registros', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
