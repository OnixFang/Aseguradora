import { Component, OnInit } from '@angular/core';
import { ICliente } from '../_models/icliente';
import { ClienteService } from '../_services/cliente.service';

@Component({
  selector: 'app-cliente-lista',
  templateUrl: './cliente-lista.component.html',
  styleUrls: ['./cliente-lista.component.css']
})
export class ClienteListaComponent implements OnInit {
  public clientes: ICliente[];

  constructor(private clienteService: ClienteService) { }

  ngOnInit() {
    this.clienteService.GetAll().subscribe(
      (clientes) => {
        this.clientes = clientes;
      },
      error => console.log(error)
    );
  }
}
