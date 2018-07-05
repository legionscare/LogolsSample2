import { Component } from '@angular/core';
import { PersonStatus } from './entities/PersonStatus';
import { PersonStatusService } from './services/PersonStatusService';

@Component({
  selector: 'ZombieReportPage',
  templateUrl: './ZombieReport.component.html',
  styleUrls: ['./ZombieReport.component.css']
})

export class ZombieReportPageComponent {

  pagetitle = 'Full Status Report';

}

@Component({
  selector: 'ZombieReportTable',
  templateUrl: './component-styles/ReportTable.html',
  styleUrls: ['./component-styles/ReportTable.css']
})

export class ZombieReportTableComponent {

  public statuses: PersonStatus[] = [];

  public constructor(personStatusService: PersonStatusService) {

    personStatusService.getAll().subscribe(result => {
      for (let status of result) {
        this.statuses.push(status);
      }
    }, error => { 
      console.log(error)
    })
  }

}