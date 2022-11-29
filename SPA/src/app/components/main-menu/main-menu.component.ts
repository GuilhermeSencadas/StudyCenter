import { Component, OnInit } from '@angular/core';
import config from 'src/../config';


@Component({
  selector: 'app-main-menu',
  templateUrl: './main-menu.component.html',
  styleUrls: ['./main-menu.component.css']
})
export class MainMenuComponent implements OnInit {

   link = {
    MainMenu: config.route.MainMenu,
    Subject: config.route.Subject
  };

  constructor() { }

  ngOnInit(): void {
  }

}
