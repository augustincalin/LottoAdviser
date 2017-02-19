import { Component, OnInit } from '@angular/core';
import { HomeService } from './home.service';
import { HomeData } from './homeData.model';
import { NumberData } from './numberData.model';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    homeData: HomeData = { topProbable: [] };
    constructor(private homeService: HomeService) { }

    ngOnInit() {
        this.homeService.getHomeData().subscribe(res => this.homeData = res);
    }
}
