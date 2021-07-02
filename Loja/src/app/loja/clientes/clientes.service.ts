import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Cliente } from './Cliente';





@Injectable()
export class ClienteService {


constructor(private http: HttpClient) { }

    protected UrlServiceV5: string = "https://localhost:5001/api/v1/Cliente";

    obterCliente(): Observable<Cliente[]> {
        return this.http.get<Cliente[]>(this.UrlServiceV5);
    }


}
