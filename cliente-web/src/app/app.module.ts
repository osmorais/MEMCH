import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ModalModule } from 'ngx-bootstrap/modal';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ToastrModule } from 'ngx-toastr';
import { ngxLoadingAnimationTypes, NgxLoadingModule } from 'ngx-loading';

import { RegistroService } from './_services/registro.service';

import { AppComponent } from './app.component';
import { RegistrosComponent } from './Registros/Registros.component';
import { LoginComponent } from './Login/Login.component';
import { MenuComponent } from './Menu/Menu.component';
import { RegraComponent } from './Regra/regra.component';
import { ConexaoComponent } from './Conexao/Conexao.component';

import { DateTimeFormatPipe } from './_helps/DateTimeFormatPipe.pipe';
import { FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NavComponent } from './nav/nav.component';
import { DashboardComponent } from './Dashboard/Dashboard.component';
import { AlertaComponent } from './Alerta/Alerta.component';

@NgModule({
  declarations: [
    AppComponent,
    RegistrosComponent,
    LoginComponent,
    RegraComponent,
    ConexaoComponent,
    DateTimeFormatPipe,
    NavComponent,
    MenuComponent,
      DashboardComponent,
      AlertaComponent
   ],
  imports: [
    BrowserModule,
    FormsModule,
    TooltipModule.forRoot(),
    BsDropdownModule.forRoot(),
    ModalModule.forRoot(),
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      timeOut: 10000,
      positionClass: 'toast-bottom-right',
      preventDuplicates: true,
    }),
    NgxLoadingModule.forRoot({
      animationType: ngxLoadingAnimationTypes.circleSwish,
      backdropBackgroundColour: 'rgba(0,0,0,0.1)',
      backdropBorderRadius: '4px',
      primaryColour: '#ffffff',
      secondaryColour: '#ffffff',
      tertiaryColour: '#ffffff'
  }),
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
  ],
  providers: [
    RegistroService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
