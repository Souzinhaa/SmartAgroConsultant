import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { ClientModel } from '../model/cliente.model';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  @Input() clienteHeader: ClientModel = {}
  @Input() menu: boolean = false
  showPerfil: boolean = false
  showFuncionalidade: boolean = false
  showProdutividade: boolean = false
  showZoneamento: boolean = false
  showAdubacao: boolean = false
  constructor(private router: Router) { }

  ngOnInit(): void {
  }
  changeMenu(index: string){
    this.menu = false
    this.showPerfil = false
    this.showFuncionalidade = false
    this.showProdutividade = false
    this.showZoneamento = false
    this.showAdubacao = false

    switch (index) {
      case "menu":
        this.menu = true
        break;
      case "perfil":
        this.showPerfil = true
        break;
      case "funcionalidade":
        this.showFuncionalidade = true
        break;
      case "produtividade":
        this.showProdutividade = true
        break;
      case "zoneamento":
        this.showZoneamento = true
        break;
      case "adubacao":
        this.showAdubacao = true
        break;
    
      default:
        this.menu = false
        this.showPerfil = false
        this.showFuncionalidade = false
        this.showProdutividade = false
        this.showZoneamento = false
        this.showAdubacao = false
        break;
      }
  }
}
