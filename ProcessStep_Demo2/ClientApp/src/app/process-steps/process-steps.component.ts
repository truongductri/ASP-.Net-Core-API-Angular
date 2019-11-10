import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { ProcessStepService } from '../services/process-step.service';
import { ProcessStep } from '../models/processstep';
@Component({
  selector: 'app-process-steps',
  templateUrl: './process-steps.component.html',
  styleUrls: ['./process-steps.component.scss']
})
export class ProcessStepsComponent implements OnInit {
  processSteps$: Observable<ProcessStep[]>;
  constructor(private processstepSvr: ProcessStepService) { }

  ngOnInit() {
    this.loadProcessSteps();
  }

  loadProcessSteps() {
    this.processSteps$ = this.processstepSvr.getProcessSteps();
  }

  delete(stepId) {
    const ans = confirm('Do you want to delete process step with id: ' + stepId);
    if (ans) {
      this.processstepSvr.deleteProcessStep(stepId).subscribe((data) => {
        this.loadProcessSteps();
      });
    }
  }
}
