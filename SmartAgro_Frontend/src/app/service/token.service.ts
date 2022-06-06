import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TokenService {

  token = 'Bearer cac1ae1f-3ff7-3441-bc93-db0921aaae43'

  constructor() { }

  getToken(){
    return this.token
  }
}
