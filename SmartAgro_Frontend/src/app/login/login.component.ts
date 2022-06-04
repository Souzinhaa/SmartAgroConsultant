import { MenuComponent } from './../menu/menu.component';
import { LoginService } from './../service/login.service';
import { Component, OnInit } from '@angular/core';
import { LoginModel } from '../model/login.model';
import { Router } from '@angular/router';
import { ClientModel } from '../model/cliente.model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  login: LoginModel = {email: "", senha: ""}
  cliente: ClientModel = {}

  constructor(private LoginService: LoginService, private router: Router) { }

  ngOnInit(): void { }

  entrar(): void{

    //var string = 'Hello World!';
    // Encode the String
    //var encodedString = btoa(string); 
    //console.log(encodedString); // Outputs: "SGVsbG8gV29ybGQh"  
    // Decode the String
    //var decodedString = atob('encodedString');
    //console.log(decodedString); // Outputs: "Hello World!"
    
    this.LoginService.entrar(this.login.email, btoa(this.login.senha)).subscribe(cliente => {
      this.cliente = cliente
      console.log(cliente)
    });
  }

}
