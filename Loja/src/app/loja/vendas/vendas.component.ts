import { Component, OnInit } from '@angular/core';
import { Venda } from './venda';
import { VendaService } from './vendas.service';


@Component({
  selector: 'app-venda',
  templateUrl: './vendas.component.html',
  providers: [VendaService]

})
export class VendaComponent implements OnInit {
  vendas: Venda [] = [];

  constructor(private vendaService: VendaService) {}

  ngOnInit(){
    this.vendaService.obterVenda()
    .subscribe(venda => {
      (this.vendas = venda)
      console.log(venda)
    })

  }
}


