import { Component, Input, OnInit } from '@angular/core';
import { ClientModel } from '../model/cliente.model';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  @Input() cliente: ClientModel = {}
  constructor() { }

  ngOnInit(): void {
  }

}
