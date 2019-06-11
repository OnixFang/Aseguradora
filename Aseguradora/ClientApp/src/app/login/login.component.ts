import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { Router } from '@angular/router';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
    errorMessage: string = null;
    username: string;
    password: string;

    constructor(private auth: AuthService, private router: Router) { }

    login(): void {
        let credenciales = { username: this.username, password: this.password };
        this.auth.login(credenciales).pipe().subscribe(usuario => {
            if (usuario == null) {
                this.errorMessage = 'Nombre de usuario/contraseña incorrectos.';
            }
            else {
                this.errorMessage = null;
                this.router.navigateByUrl("/");
            }
        });
    }

    ngOnInit() {
    }
}
