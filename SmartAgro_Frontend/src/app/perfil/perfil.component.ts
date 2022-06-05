import { Component, Input, OnInit } from '@angular/core';
import { ClientModel } from '../model/cliente.model';

@Component({
  selector: 'app-perfil',
  templateUrl: './perfil.component.html',
  styleUrls: ['./perfil.component.scss']
})
export class PerfilComponent implements OnInit {

  @Input() clientePerfil: ClientModel = {}
  constructor() { }

  ngOnInit(): void {
  }

}
