import { Component, OnInit } from '@angular/core';
import { ZoneamentoModel } from '../model/zoneamento.model';
import { ZoneamentoService } from '../service/zoneamento.service';

@Component({
  selector: 'app-zoneamento',
  templateUrl: './zoneamento.component.html',
  styleUrls: ['./zoneamento.component.scss']
})
export class ZoneamentoComponent implements OnInit {
  
  zoneamentosEmbrapa:ZoneamentoModel = {data: [{}]}

  constructor(private zoneamentoService: ZoneamentoService) { }

  ngOnInit(): void {
      this.zoneamentoService.getZoneamentosByParam(56, 4219853, 20).subscribe(zoneamento => {      
      //this.zoneamentoService.getZoneamentosByParam(61, 3500204, 20).subscribe(zoneamento => {      
      this.zoneamentosEmbrapa = zoneamento
    })
  }

}
