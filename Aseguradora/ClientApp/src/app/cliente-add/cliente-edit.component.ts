import { Component, OnInit } from '@angular/core';
import { ICliente } from '../_models/icliente';
import { ClienteService } from '../_services/cliente.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
    selector: 'app-cliente-edit',
    templateUrl: './cliente-add.component.html',
    styleUrls: ['./cliente-add.component.css']
})
export class ClienteEditComponent implements OnInit {
    public pageTitle: string = 'Editar Cliente';
    public cliente: ICliente;

    constructor(private clienteService: ClienteService, private router: Router, private route: ActivatedRoute) { }

    crear(): void {
        this.clienteService.UpdateCliente(this.cliente).subscribe(updatedCliente => {
            if (updatedCliente) {
                this.router.navigateByUrl('clientes');
            }
        });
    }

    ngOnInit() {
        this.clienteService.GetCliente(this.route.snapshot.params.id).subscribe(cliente => {
            if (cliente) {
                this.cliente = cliente;
            }
            else {
                this.router.navigateByUrl("clientes");
            }
        });
    }
}
