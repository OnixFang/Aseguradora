import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { IUsuario } from '../_models/iusuario';

@Component({
    selector: 'app-nav-menu',
    templateUrl: './nav-menu.component.html',
    styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
    constructor(private auth: AuthService) { }

    logout(): void {
        this.auth.logout();
    }

    ngOnInit() {

    }
}
