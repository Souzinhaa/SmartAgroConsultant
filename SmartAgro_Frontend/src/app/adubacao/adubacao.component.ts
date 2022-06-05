import { Component, Input, OnInit } from '@angular/core';
import { AdubacaoModel, FormulacoesModel } from '../model/adubacao.model';
import { ClientModel } from '../model/cliente.model';
import { AdubacaoService } from '../service/adubacao.service';

@Component({
  selector: 'app-adubacao',
  templateUrl: './adubacao.component.html',
  styleUrls: ['./adubacao.component.scss']
})
export class AdubacaoComponent implements OnInit {
  
  adubacaoEmbrapa: AdubacaoModel = {data: {}}
  @Input() clienteAdubacao: ClientModel = {}

  constructor(private AdubacaoService: AdubacaoService) { }

  ngOnInit(): void {
      //this.zoneamentoService.getZoneamentosByParam(56, 4219853, 20).subscribe(zoneamento => {      
      this.AdubacaoService.getAdubacaoByParam(56, 10, 1, 1, 10, 25, 150, 50, 500, 50, 80).subscribe(adubacao => {      
        this.adubacaoEmbrapa = adubacao
      })
  }

}
