import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProcessStepsComponent } from './process-steps/process-steps.component';
import { ProcessStepService } from './services/process-step.service';

@NgModule({
  declarations: [
    AppComponent,
    ProcessStepsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [
    ProcessStepService,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
