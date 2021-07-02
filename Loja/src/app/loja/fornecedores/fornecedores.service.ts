import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Fornecedor } from './Fornecedor';



@Injectable()
export class FornecedorService {
  

constructor(private http: HttpClient) { }

    protected UrlServiceV3: string = "https://localhost:5001/api/v1/Fornecedor";

    obterFornecedor(): Observable<Fornecedor[]> {
        return this.http.get<Fornecedor[]>(this.UrlServiceV3);        
    }

    
}