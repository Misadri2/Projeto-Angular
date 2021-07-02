import { VendaService } from './loja/vendas/vendas.service';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { rootRouterConfig } from './app.routes';
import { ProdutosComponent } from './loja/produtos/produtos.component';
import { HomeComponent } from './Navegacao/home/home.component';
import { ProdutoService } from './loja/produtos/produtos.service';
import { APP_BASE_HREF } from '@angular/common';
import { ClientesComponent } from './loja/clientes/clientes.component';
import { FornecedoresComponent } from './loja/fornecedores/fornecedores.component';
import { MatFormFieldModule} from '@angular/material/form-field';
import { MatInputModule} from '@angular/material/input';
import { ClienteService } from './loja/clientes/clientes.service';
import { FornecedorService } from './loja/fornecedores/fornecedores.service';
import { EstoqueService } from './loja/estoques/estoques.service';
import { EstoquesComponent } from './loja/estoques/estoques.component';
import { VendaComponent } from './loja/vendas/vendas.component';




@NgModule({
  declarations: [
    AppComponent,
    ProdutosComponent,
    HomeComponent,
    ClientesComponent,
    EstoquesComponent,
    FornecedoresComponent,
    VendaComponent,
  ],


  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    MatFormFieldModule,
    MatInputModule,
    [RouterModule.forRoot(rootRouterConfig, { useHash: false})]
  ],
  providers: [
    ProdutoService,
    ClienteService,
    EstoqueService,
    VendaService,
    FornecedorService,
    {provide: APP_BASE_HREF, useValue: '/'}
  ],

  bootstrap: [AppComponent]
})
export class AppModule { }
