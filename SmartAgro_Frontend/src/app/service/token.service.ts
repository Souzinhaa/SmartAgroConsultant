import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TokenService {

  token = 'Bearer a15a4cb2-77bb-3f63-a3a0-d483741f0c1f'

  constructor() { }

  getToken(){
    return this.token
  }
}
