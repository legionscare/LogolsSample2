import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { ZombieFrontPageComponent } from './ZombieFrontPage.component';
import { ZombieReportPageComponent, ZombieReportTableComponent } from './ZombieReport.component';
import { ZombieAddStatusPageComponent } from './ZombieAddStatusPage.component';
import { Error404PageComponent, MenuComponent, EntryFormComponent } from './PageBasics.component';

import { PersonStatusService } from './services/PersonStatusService';

const appRoutes: Routes = [
  { path: 'addStatus', component: ZombieAddStatusPageComponent },
  { path: 'report', component: ZombieReportPageComponent },
  { path: '', component: ZombieFrontPageComponent },
  { path: '**', component: Error404PageComponent }
];

@NgModule({
  declarations: [
    AppComponent, 
    ZombieFrontPageComponent,
    ZombieReportPageComponent, ZombieReportTableComponent, 
    ZombieAddStatusPageComponent,
    Error404PageComponent,
    MenuComponent, EntryFormComponent
  ],
  imports: [
    BrowserModule, 
    HttpClientModule, 
    FormsModule,
    RouterModule.forRoot( appRoutes )
  ],
  providers: [ PersonStatusService ],
  bootstrap: [ AppComponent ]
})

export class AppModule { }
