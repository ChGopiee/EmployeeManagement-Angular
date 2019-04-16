import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutes } from './app.route';
import { FormsModule } from '@angular/forms';
import { HttpService } from '../Services/HttpService';
import { Router, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(AppRoutes, { enableTracing: false, initialNavigation: false, useHash: true })
  ],
  providers: [HttpService],
  bootstrap: [AppComponent]
})
export class AppModule { }
