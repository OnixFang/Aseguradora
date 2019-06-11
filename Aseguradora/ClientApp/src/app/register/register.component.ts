import { Component, OnInit } from '@angular/core';
import { IUsuario } from '../_models/iusuario';
import { Rol } from '../_models/rol.enum';
import { AuthService } from '../_services/auth.service';
import { Router } from '@angular/router';

@Component({
    selector: 'app-register',
    templateUrl: './register.component.html',
    styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
    public keys = Object.keys;
    public roles = ["Agente", "Supervisor", "Gerente"];
    public selectedValue = null;

    public usuario: IUsuario = {
        id: 0,
        username: null,
        password: null,
        rol: null,
        persona: {
            id: 0,
            nombre: null,
            apellido: null
        }
    };

    constructor(private auth: AuthService, private router: Router) { }

    save(): void {
        this.usuario.rol = this.selectedValue;
        this.auth.register(this.usuario).subscribe(result => {
            if (result != null) {
                this.router.navigateByUrl('/');
            }
        });
    }

    ngOnInit() {
    }

}
