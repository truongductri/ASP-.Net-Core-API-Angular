import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProcessStepsComponent } from './process-steps/process-steps.component';


const routes: Routes = [
  { path: '', component: ProcessStepsComponent, pathMatch: 'full' },
  { path: 'processStep/:id', component: ProcessStepsComponent },
  { path: '**', redirectTo: '/' }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
