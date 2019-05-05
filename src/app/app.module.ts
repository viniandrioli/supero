import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { Ng2SmartTableModule } from 'ng2-smart-table';
import { TasklistComponent } from '../components/tasklist/tasklist.component';
import { TasklistService } from '../components/tasklist/tasklist.service';
import { HomeComponent } from '../components/home/home.component';



@NgModule({
  declarations: [
    TasklistComponent,
    AppComponent,
    HomeComponent
    
  ],
  imports: [
    BrowserModule,
    Ng2SmartTableModule,
    HttpClientModule,
    AppRoutingModule

  ],
  providers: [
    TasklistService
  ],
  entryComponents: [
    TasklistComponent
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
