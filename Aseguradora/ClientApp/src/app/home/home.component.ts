import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { Rol } from '../_models/rol.enum';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
    constructor(private auth: AuthService) { }
    public canRegister: boolean = false;

    ngOnInit() {
        if (this.auth.currentUser().rol === Rol.Gerente) {
            this.canRegister = true;
        }
    }
}

