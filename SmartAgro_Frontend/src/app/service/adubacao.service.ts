import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { AdubacaoModel } from '../model/adubacao.model';
import { TokenService } from './token.service';

@Injectable({
  providedIn: 'root'
})
export class AdubacaoService {

  url = "http://localhost:3001/zoneamento/";    
  urlEmbrapa = 'https://api.cnptia.embrapa.br/agritec/v1/adubacao/recomendacao'
  constructor(private http: HttpClient, private token: TokenService) { } 
  
  getAdubacaoByParam(idCultura: any, expectativaProdutividade: any, identificadorMetodoExtracaoFosforo: any, identificadorClasseTexturalSolo: any, capacidadeTrocaCation: any, fosforo: any, potassio: any, materiaOrganica: any, teorArgila: any, saturacaoPorBases: any, prntCalcario: any): Observable<AdubacaoModel>{
    let headers = new HttpHeaders()
    headers = headers.set('content-type', 'application/json');
    headers = headers.set('Authorization', this.token.getToken());
    return this.http.get<AdubacaoModel>(`${this.urlEmbrapa}?idCultura=${idCultura}&expectativaProdutividade=${expectativaProdutividade}&identificadorMetodoExtracaoFosforo=${identificadorMetodoExtracaoFosforo}&identificadorClasseTexturalSolo=${identificadorClasseTexturalSolo}&capacidadeTrocaCation=${capacidadeTrocaCation}&fosforo=${fosforo}&potassio=${potassio}&materiaOrganica=${materiaOrganica}&teorArgila=${teorArgila}&saturacaoPorBases=${saturacaoPorBases}&prntCalcario=${prntCalcario}`,{ headers })
  }
}
