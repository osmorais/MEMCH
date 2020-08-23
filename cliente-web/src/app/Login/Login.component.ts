import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  // tslint:disable-next-line: component-selector
  selector: 'app-Login',
  templateUrl: './Login.component.html',
  styleUrls: ['./Login.component.css']
})
export class LoginComponent implements OnInit {
  registerForm: FormGroup;

  constructor() { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
  }

  // tslint:disable-next-line: typedef
  validation(){
    this.registerForm = new FormGroup({
      login: new FormControl('', [Validators.required, Validators.minLength(4), Validators.maxLength(20)]),
      senha: new FormControl('', Validators.required),
    });
  }

}
