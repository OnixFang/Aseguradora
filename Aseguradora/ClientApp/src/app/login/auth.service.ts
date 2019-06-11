import { Injectable } from '@angular/core';
import { IUsuario } from './iusuario';
import { UsuarioService } from './usuario.service';

@Injectable({
    providedIn: 'root'
})
export class AuthService {
    constructor(private usuarioService: UsuarioService) { }

    currentUser(): IUsuario {
        return JSON.parse(localStorage.getItem('currentUser'));
    }

    login(credenciales) {
        this.usuarioService.GetUsuario(credenciales).subscribe((usuario) => {
            localStorage.setItem('currentUser', JSON.stringify(usuario));
            return usuario;
        });
    }

    logout(): void {
        localStorage.setItem('currentUser', null);
    }
}
