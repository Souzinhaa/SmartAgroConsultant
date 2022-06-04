import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ClientModel } from '../model/cliente.model';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  url = 'https://localhost:44386/api/Cache/'

  constructor(private http: HttpClient) { } 
  
  entrar(login: string, senha: string): Observable<ClientModel>{
    let headers = new HttpHeaders()
    headers = headers.set('Access-Control-Allow-Origin', '*');
    headers = headers.set('content-type', 'application/json');
    console.log(this.http.get<ClientModel>(`${this.url}${login}&${senha}`,{ headers }))
    return this.http.get<ClientModel>(`${this.url}${login}&${senha}`,{ headers })
  }
}
