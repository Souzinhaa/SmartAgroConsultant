import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ClientModel } from '../model/cliente.model';
import { CriarContaModel } from '../model/criarconta.model';

@Injectable({
  providedIn: 'root'
})
export class CriarcontaService {

  url = 'https://localhost:5001/smartagro'

  erro(codigo: number): String{
    switch (codigo){
      case 401:
        return "Sem autorização!!"

      case 400:
        return "Bad Request!!"

      default:
        return ""
    }
  }
  
  constructor(private http: HttpClient) { } 
  
  criarUsuario(login: CriarContaModel): Observable<ClientModel>{
    let headers = new HttpHeaders()
    headers = headers.set('Access-Control-Allow-Origin', '*');
    headers = headers.set('content-type', 'application/json');
    //return this.http.post<CriarcontaModel>(`${this.url}/userLogin?email=${login.email}&senha=${login.senha}&nomeusu=${login.nomeusu}&nome=${login.nome}`,{ headers })
    return this.http.post<CriarContaModel>(this.url, login)  
  }
}
