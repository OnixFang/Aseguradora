import { Injectable, Inject } from '@angular/core';
import { IUsuario } from '../_models/iusuario';
import { map } from 'rxjs/operators';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class AuthService {
    private authApi: string;

    constructor(private http: HttpClient, private route: Router, @Inject('BASE_URL') baseUrl: string) {
        this.authApi = baseUrl + 'api/Auth';
    }

    currentUser(): IUsuario {
        return JSON.parse(localStorage.getItem('currentUser'));
    }

    login(credenciales): Observable<IUsuario> {
        return this.http.post<IUsuario>(`${this.authApi}/Login`, credenciales).pipe(map(usuario => {
            localStorage.setItem('currentUser', JSON.stringify(usuario));
            return usuario;
        }));
    }

    logout(): void {
        localStorage.setItem('currentUser', null);
        this.route.navigateByUrl('/login');
    }

    register(newUsuario: IUsuario): Observable<IUsuario> {
        return this.http.post<IUsuario>(`${this.authApi}/Add`, newUsuario).pipe(map(usuario => {
            this.route.navigateByUrl('/');
            return usuario;
        }));
    }
}
