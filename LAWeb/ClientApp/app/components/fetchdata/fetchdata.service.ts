import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map';


@Injectable()
export class FetchDataService {
    private fetchDataUrl: string = '/api/data/fetch';
    constructor(private http: Http) { }

    saveData(): Observable<boolean> {
        return this.http.get(this.fetchDataUrl).map(r => true);
    }

}