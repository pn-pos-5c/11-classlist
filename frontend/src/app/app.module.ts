import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { HttpClientModule } from "@angular/common/http";
import { StudentRowComponent } from './components/student-row/student-row.component';
import {FormsModule} from "@angular/forms";
import { LogComponent } from './components/log/log.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    StudentRowComponent,
    LogComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
