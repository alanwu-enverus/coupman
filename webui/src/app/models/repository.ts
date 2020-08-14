import { Party } from "./party.model";
import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';

@Injectable()
export class Repository {
    // baseUrl = 'http://localhost:5000/'
    baseUrl = 'http://localhost:5051/'
    party$: Observable<Party>;
    constructor(private http:HttpClient) {
        this.party$ = this.http.get<Party>(`${this.baseUrl}Party/1`)
    }
}