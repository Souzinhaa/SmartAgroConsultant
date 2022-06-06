import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ZoneamentoModel} from '../model/zoneamento.model';
import { TokenService } from './token.service';

@Injectable({
  providedIn: 'root'
})
export class ZoneamentoService {

  url = "http://localhost:3001/zoneamento/";    
  urlEmbrapa = 'https://api.cnptia.embrapa.br/agritec/v1/zoneamento'
  constructor(private http: HttpClient, private token: TokenService) { } 
  
  getZoneamentosByParam(idCultura: any, codigoIBGE : any, risco : any): Observable<ZoneamentoModel>{
    //console.log(this.header.get('Authorization'))
    let headers = new HttpHeaders()
    headers = headers.set('content-type', 'application/json');
    headers = headers.set('Authorization', this.token.getToken());
    return this.http.get<ZoneamentoModel>(`${this.urlEmbrapa}?idCultura=${idCultura}&codigoIBGE=${codigoIBGE}&risco=${risco}`,{ headers })
  }
}
