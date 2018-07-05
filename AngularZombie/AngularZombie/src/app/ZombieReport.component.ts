import { Component } from '@angular/core';
import { build$ } from 'protractor/built/element';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Zombie Status Report';
}