import { Component } from '@angular/core';
import { FetchDataService } from './fetchdata.service';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    private loaded: boolean = false;

    constructor(private fetchDataService: FetchDataService) { }

    loadData() {
        this.fetchDataService.saveData().subscribe(
            r => { this.loaded = true; console.log(this.loaded); }
    );
    }
}