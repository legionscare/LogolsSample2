import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { ZombieReportComponent } from './ZombieReport.component';

@NgModule({
  declarations: [
    ZombieReportComponent,
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [ZombieReportComponent]
})
export class ZombieReportModule { }
