import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { Icliente } from './icliente';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class ClienteService {
  private clientApi: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.clientApi = baseUrl + 'api/Cliente';
  }

  GetAll(): Observable<Icliente[]> {
    return this.http.get<Icliente[]>(this.clientApi);
  }
}
