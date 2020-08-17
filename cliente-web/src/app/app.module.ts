import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { TooltipModule} from 'ngx-bootstrap/tooltip';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ModalModule } from 'ngx-bootstrap/modal';
import { NgModule } from '@angular/core';

import { RegistroService } from './_services/registro.service';

import { RegistrosComponent } from './Registros/Registros.component';
import { LoginComponent } from './Login/Login.component';
import { AppComponent } from './app.component';

import { DateTimeFormatPipe } from './_helps/DateTimeFormatPipe.pipe';
import { RegraComponent } from './Regra/Regra/regra.component';
import { FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
      RegistrosComponent,
      LoginComponent,
      RegraComponent,
      DateTimeFormatPipe
   ],
  imports: [
    BrowserModule,
    FormsModule,
    TooltipModule.forRoot(),
    BsDropdownModule.forRoot(),
    ModalModule.forRoot(),
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [
    RegistroService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
