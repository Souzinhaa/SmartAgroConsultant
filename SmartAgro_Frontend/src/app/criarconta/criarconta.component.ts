import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { CriarcontaModel } from '../model/criarconta.model';
import { ClientModel } from '../model/cliente.model';
import { Router } from '@angular/router';
import { CriarcontaService } from '../service/criarconta.service';


@Component({
  selector: 'app-criarconta',
  templateUrl: './criarconta.component.html',
  styleUrls: ['./criarconta.component.scss']
})
export class CriarcontaComponent implements OnInit {

  criarconta: CriarcontaModel = {nome: "",nomeusu:"",email: "", senha: ""}
  cliente: ClientModel = {}
  @Output() dadosCliente = new EventEmitter<string>(); //  @Output(alias) propertyName = ...

  constructor(private CriarcontaService: CriarcontaService, private router: Router) { }

  ngOnInit(): void { }

  criarusu(): void{
    this.criarconta.senha = btoa(this.criarconta.senha)
    this.criarconta.nome = btoa(this.criarconta.nome)
    this.criarconta.nomeusu = btoa(this.criarconta.nomeusu)
    if(this.criarconta.email != "" && this.criarconta.senha != "" && this.criarconta.nome != "" && this.criarconta.nomeusu != "")
      this.CriarcontaService.criarusu(this.criarconta).subscribe(cliente => {
        this.cliente = cliente
        this.dadosCliente.emit("Deu Certo");
        this.router.navigate([""]);

      }, e => {
        alert(this.CriarcontaService.erro(e.status))
      })
    else if(this.criarconta.nome == "")
    alert("Preencha o Nome de usuário!!")
    else if(this.criarconta.nomeusu == "")
      alert("Preencha o Apelido de usuário!!")
    else if(this.criarconta.email == "")
      alert("Preencha o endereço de usuário!!")
    else if(this.criarconta.senha == "")
      alert("Preencha a Senha de usuário!!")
  }

}
