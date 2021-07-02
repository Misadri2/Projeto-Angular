import { Component, OnInit } from '@angular/core';
import { Estoque } from './estoque';
import { EstoqueService } from './estoques.service';

@Component({
  selector: 'app-estoques',
  templateUrl: './estoques.component.html',
  providers: [EstoqueService]
})
export class EstoquesComponent implements OnInit {
  estoques: Estoque [] = [];

  constructor(private estoqueService: EstoqueService) {}

  ngOnInit(){
    this.estoqueService.obterEstoque()
    .subscribe(estoques => (this.estoques = estoques));
  }
}

