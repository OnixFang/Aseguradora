import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { ICliente } from '../_models/icliente';
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

    GetCliente(id: number): Observable<ICliente> {
        return this.http.get<ICliente>(`${this.clientApi}/${id}`);
    }

    UpdateCliente(cliente: ICliente): Observable<ICliente> {
        return this.http.post<ICliente>(this.clientApi, cliente);
    }

    DeleteCliente(cliente: ICliente): Observable<ICliente> {
        return this.http.post<ICliente>(`${this.clientApi}/Delete`, cliente);
    }
}
