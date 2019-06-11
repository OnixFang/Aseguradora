import { Component, OnInit } from '@angular/core';
import { ICliente } from '../_models/icliente';
import { ClienteService } from '../_services/cliente.service';
import { Router } from '@angular/router';

@Component({
    selector: 'app-cliente-add',
    templateUrl: './cliente-add.component.html',
    styleUrls: ['./cliente-add.component.css']
})
export class ClienteAddComponent implements OnInit {
    public pageTitle: string = 'Nuevo Cliente';

    public cliente: ICliente = {
        id: 0,
        nombre: null,
        apellido: null,
        cedula: null,
        telefono: null,
        direccion: null,
        ciudad: null,
        polizas: null
    };

    constructor(private clienteService: ClienteService, private router: Router) { }

    crear(): void {
        this.clienteService.AddCliente(this.cliente).subscribe(newCliente => {
            if (newCliente) {
                this.router.navigateByUrl('clientes');
            }
        });
    }

    ngOnInit() {
    }
}
