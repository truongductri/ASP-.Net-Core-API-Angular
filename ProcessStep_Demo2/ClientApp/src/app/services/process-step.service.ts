import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { ProcessStep } from '../models/processstep';

@Injectable({
  providedIn: 'root'
})
export class ProcessStepService {

  myAppUrl: string;
  myApiUrl: string;
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json; charset=utf-8'
    })
  };
  constructor(private http: HttpClient) {
    this.myAppUrl = environment.appUrl;
    this.myApiUrl = 'api/procsteps/';
  }

  getProcessSteps(): Observable<ProcessStep[]> {
    return this.http.get<ProcessStep[]>(this.myAppUrl + this.myApiUrl)
      .pipe(
        retry(1),
        catchError(this.errorHandler)
      );
  }

  getProcessStep(stepId: number): Observable<ProcessStep> {
    return this.http.get<ProcessStep>(this.myAppUrl + this.myApiUrl + stepId)
      .pipe(
        retry(1),
        catchError(this.errorHandler)
      );
  }

  saveProcessStep(blogPost): Observable<ProcessStep> {
    return this.http.post<ProcessStep>(this.myAppUrl + this.myApiUrl, JSON.stringify(blogPost), this.httpOptions)
      .pipe(
        retry(1),
        catchError(this.errorHandler)
      );
  }

  updateProcessStep(stepId: number, blogPost): Observable<ProcessStep> {
    return this.http.put<ProcessStep>(this.myAppUrl + this.myApiUrl + stepId, JSON.stringify(blogPost), this.httpOptions)
      .pipe(
        retry(1),
        catchError(this.errorHandler)
      );
  }

  deleteProcessStep(stepId: number): Observable<ProcessStep> {
    return this.http.delete<ProcessStep>(this.myAppUrl + this.myApiUrl + stepId)
      .pipe(
        retry(1),
        catchError(this.errorHandler)
      );
  }

  errorHandler(error) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      // Get client-side error
      errorMessage = error.error.message;
    } else {
      // Get server-side error
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    console.log(errorMessage);
    return throwError(errorMessage);
  }
}
