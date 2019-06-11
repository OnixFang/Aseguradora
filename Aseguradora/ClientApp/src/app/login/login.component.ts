import { Component, OnInit } from '@angular/core';
import { AuthService } from './auth.service';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
    errorMessage: string = null;
    username: string;
    password: string;

    constructor(private auth: AuthService) { }

    login(): void {
        let credenciales = { username: this.username, password: this.password };
        let usuario = this.auth.login(credenciales);
        if (usuario == null) {
            this.errorMessage = 'Invalid username/password.';
        }
        else {
            this.errorMessage = null;
        }
    }

    ngOnInit() {
    }
}
