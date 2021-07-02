import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Produto } from './produto';


@Injectable({
    providedIn: 'root'
  })  
export class ProdutoService {   
  

constructor(private http: HttpClient) { }

UrlServiceV1= 'https://localhost:5001/api/v1/Produto';

   
    obterProduto(): Observable<Produto[]> {
        return this.http.get<Produto[]>(this.UrlServiceV1);        
    }

    addProduto(produto: Produto): Observable<Produto> {
        return this.http.post<Produto>(this.UrlServiceV1, produto);        
    }

    updateProduto(produto:Produto): Observable<Produto> {
        return this.http.put<Produto>(this.UrlServiceV1, produto);
    } 

    deleteProduto(idProduto: Number): Observable<Produto> {
        const url = `${this.UrlServiceV1}/${idProduto}`; 
        return this.http.delete<Produto>(url);
    }
    
}