import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IUsuario } from './iusuario';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class UsuarioService {
    private authApi: string;

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.authApi = baseUrl + 'api/Auth';
    }

    GetUsuario(credenciales): Observable<IUsuario> {
        return this.http.post<IUsuario>(`${this.authApi}/Login`, credenciales);
    }
}
