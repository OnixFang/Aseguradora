import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { ICliente } from './ICliente';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class ClienteService {
  private clientApi: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.clientApi = baseUrl + 'api/Cliente';
  }

  GetAll(): Observable<ICliente[]> {
    return this.http.get<ICliente[]>(this.clientApi);
  }
}
