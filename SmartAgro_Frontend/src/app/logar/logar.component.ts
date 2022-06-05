import { LoginService } from './../service/login.service';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { LoginModel } from '../model/login.model';
import { ClientModel } from '../model/cliente.model';
import { Router } from '@angular/router';


@Component({
  selector: 'app-logar',
  templateUrl: './logar.component.html',
  styleUrls: ['./logar.component.scss']
})
export class LogarComponent implements OnInit {

  login: LoginModel = {email: "fecorba", senha: "corbahomi"}
  clienteLogin: ClientModel = {}
  

  constructor(private LoginService: LoginService, private router: Router) { }

  ngOnInit(): void { }

  entrar(): void{
    this.login.senha = btoa(this.login.senha)
    if(this.login.email != "" && this.login.senha != "")
      this.LoginService.entrar(this.login).subscribe(cliente => {
        this.clienteLogin = cliente
      }, e => {
        alert(this.LoginService.erro(e.status))
      })
    else if(this.login.email == "")
      alert("Preencha o Nome de usuário!!")
    else if(this.login.senha == "")
      alert("Preencha a Senha de usuário!!")
  }

}
