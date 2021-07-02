import { Routes } from "@angular/router";
import { ClientesComponent } from "./loja/clientes/clientes.component";
import { EstoquesComponent } from "./loja/estoques/estoques.component";
import { FornecedoresComponent } from "./loja/fornecedores/fornecedores.component";
import { ProdutosComponent } from "./loja/produtos/produtos.component";
import { VendaComponent } from "./loja/vendas/vendas.component";
import { HomeComponent } from "./Navegacao/home/home.component";



export const rootRouterConfig: Routes = [
    { path: '', redirectTo: '/home', pathMatch: 'full' },
    { path: 'home', component: HomeComponent },
    { path: 'produtos', component: ProdutosComponent },
    { path: 'clientes', component: ClientesComponent },
    { path: 'fornecedores', component: FornecedoresComponent },
    { path: 'estoques', component: EstoquesComponent },
    { path: 'vendas', component: VendaComponent },

];
