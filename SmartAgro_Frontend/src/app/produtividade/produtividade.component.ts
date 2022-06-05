import { Component, Input, OnInit } from '@angular/core';
import { ClientModel } from '../model/cliente.model';

@Component({
  selector: 'app-produtividade',
  templateUrl: './produtividade.component.html',
  styleUrls: ['./produtividade.component.scss']
})
export class ProdutividadeComponent implements OnInit {

  constructor() { }
  @Input() clienteProdutividade: ClientModel = {}

  ngOnInit(): void {
  }
}
