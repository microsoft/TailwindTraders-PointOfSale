import { Component } from '@angular/core';
import { WebMapService } from '@mobilize/angularclient';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  constructor( private webmapService: WebMapService) {
   webmapService.init();
 }
}
