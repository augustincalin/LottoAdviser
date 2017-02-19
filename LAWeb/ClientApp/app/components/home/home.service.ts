import { Http, Response } from '@angular/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Rx';
import { HomeData } from './homeData.model';

import 'rxjs/add/operator/map';

@Injectable()
export class HomeService {
    private homeUrl = '/api/home/getdata/10';
    constructor(private http: Http) {
    }

    getHomeData():Observable<HomeData> {
        return this.http.get(this.homeUrl).map((res:Response)=>res.json());
    }
}