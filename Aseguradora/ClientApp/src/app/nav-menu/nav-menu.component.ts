import { Component, OnInit } from '@angular/core';
import { AuthService } from '../login/auth.service';
import { IUsuario } from '../login/iusuario';

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
