import { Component, OnInit } from '@angular/core';
import { Fornecedor } from './Fornecedor';
import { FornecedorService } from './fornecedores.service';

@Component({
  selector: 'app-fornecedores',
  templateUrl: './fornecedores.component.html',
  providers: [FornecedorService]
  
})
export class FornecedoresComponent implements OnInit {
  fornecedores: Fornecedor [] = [];

  constructor(private fornecedorService: FornecedorService) { }

  ngOnInit(){
    this.fornecedorService.obterFornecedor()
    .subscribe(fornecedores => (this.fornecedores = fornecedores));
  }

}






  