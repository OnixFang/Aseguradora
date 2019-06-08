import { Component, OnInit } from '@angular/core';
import { Icliente } from './icliente';
import { ClienteService } from './cliente.service';

@Component({
  selector: 'app-cliente-lista',
  templateUrl: './cliente-lista.component.html',
  styleUrls: ['./cliente-lista.component.css']
})
export class ClienteListaComponent implements OnInit {
  public clientes: Icliente[];

  constructor(private clienteService: ClienteService) { }

  ngOnInit() {
    this.clienteService.GetAll().subscribe(
      (clientes) => {
        this.clientes = clientes;
        console.log(this.clientes[0]);
      },
      error => console.log(error)
    );
  }
}
