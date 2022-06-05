import { Component, Input, OnInit } from '@angular/core';
import { ClientModel } from '../model/cliente.model';

@Component({
  selector: 'app-funcionalidade',
  templateUrl: './funcionalidade.component.html',
  styleUrls: ['./funcionalidade.component.scss']
})
export class FuncionalidadeComponent implements OnInit {

  @Input() clienteFuncionalidade: ClientModel = {}

  constructor() { }

  ngOnInit(): void {
  }

}
