import { Component, OnInit } from '@angular/core';
import { Cliente } from './Cliente';
import { ClienteService } from './clientes.service';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',  
  providers: [ClienteService]
})
export class ClientesComponent implements OnInit {
  clientes: Cliente [] = [];

  constructor(private clienteService: ClienteService) {}

  ngOnInit(){
    this.clienteService.obterCliente()
    .subscribe(clientes => (this.clientes = clientes));
  }
}




 
