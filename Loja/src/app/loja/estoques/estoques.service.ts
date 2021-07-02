import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Estoque } from './estoque';




@Injectable()
export class EstoqueService {
  

constructor(private http: HttpClient) { }

    protected UrlServiceV5: string = "https://localhost:5001/api/v1/Estoque";

    obterEstoque(): Observable<Estoque[]> {
        return this.http.get<Estoque[]>(this.UrlServiceV5);        
    }

    
}
