import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Venda } from './venda';


@Injectable()
export class VendaService {


constructor(private http: HttpClient) { }

    protected UrlServiceV6: string = "https://localhost:5001/api/v1/Venda";

    obterVenda(): Observable<Venda[]> {
        return this.http.get<Venda[]>(this.UrlServiceV6);
    }


}
