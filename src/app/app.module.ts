import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { AppService } from './app.service';
import { Ng2SmartTableModule } from 'ng2-smart-table';



@NgModule({
  declarations: [
    AppComponent
    
  ],
  imports: [
    BrowserModule,
    Ng2SmartTableModule,
    HttpClientModule

  ],
  providers: [
    AppService
  ],
  entryComponents: [
    
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
