import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ClientModel } from '../model/cliente.model';
import { LoginModel } from '../model/login.model';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

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
  
  entrar(login: LoginModel): Observable<ClientModel>{
    let headers = new HttpHeaders()
    headers = headers.set('Access-Control-Allow-Origin', '*');
    headers = headers.set('content-type', 'application/json');
    return this.http.get<ClientModel>(`${this.url}/userLogin?name=${login.email}&senha=${login.senha}`,{ headers })
  }
}
