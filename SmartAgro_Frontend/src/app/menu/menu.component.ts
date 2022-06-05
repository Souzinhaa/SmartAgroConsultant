import { Component, Input, OnInit } from '@angular/core';
import { ClientModel } from '../model/cliente.model';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss']
})
export class MenuComponent implements OnInit {


  login: boolean = true;
  @Input() clienteMenu: ClientModel = {}
  constructor() { }

  ngOnInit(): void {
  }

}
