import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { MatNativeDateModule } from '@angular/material/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatMenuModule } from '@angular/material/menu';
import { MatIconModule } from '@angular/material/icon';
import { MaterialExampleModule } from '../material.module';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import config from '../../config';
import { MainMenuComponent } from './components/main-menu/main-menu.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { SubjectComponent } from './components/subject/subject.component';


@NgModule({
  declarations: [
    AppComponent,
    MainMenuComponent,
    PageNotFoundComponent,
    SubjectComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    RouterModule.forRoot([
    {path:'Subject',component:SubjectComponent},
      { path:'Home', component: MainMenuComponent },
      { path: '', redirectTo: '/Home', pathMatch: 'full' },
      {path:'**',component:PageNotFoundComponent},
    ]),
    MatNativeDateModule,
    BrowserAnimationsModule,
    MatMenuModule,
    MatIconModule,
    MaterialExampleModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
