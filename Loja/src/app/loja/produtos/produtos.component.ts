import { Component, OnInit } from '@angular/core';
import { ProdutoService } from './produtos.service';
import { Produto } from './produto';
import { FormGroup } from '@angular/forms';



@Component({
  selector: 'app-produtos',
  templateUrl: './produtos.component.html',
  providers: [ProdutoService]
})

export class ProdutosComponent implements OnInit {

  produtos: Produto[] = [];
  Produtos!: Produto;



  constructor(private produtoService: ProdutoService ) {}


  ngOnInit(){

    this.produtoService.obterProduto()
    .subscribe(produto => (this.produtos = produto));

    /* this.produtoService.deleteProduto(Produto.idProduto)    .subscribe(); */
  }
  CriarProduto(){
    this.produtoService.addProduto(this.Produtos)
   .subscribe(produto => (this.produtos.push(produto)));
  }
}









