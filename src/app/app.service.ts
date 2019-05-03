
import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { Tasklist } from '../models/tasklist.model'
import { AppConfig } from '../app/app.config';

@Injectable()
export class AppService {

  info: any;

  constructor(private http: HttpClient) {
  }


  addtask(data): Observable<any> {  
    let headers = new HttpHeaders().set('Access-Control-Allow-Origin', `*`);
    data.taskid = data.id;

    return this.http.post<Tasklist>(`${AppConfig.apiEndpoint}tasklist/addtask`, data, { headers : headers })   
  }

  updatetask(data): Observable<any> {  
    let headers = new HttpHeaders().set('Access-Control-Allow-Origin', `*`);

    return this.http.post<Tasklist>(`${AppConfig.apiEndpoint}tasklist/updatetask`, data, { headers : headers })   
  }

  deletetask(data): Observable<any> {  
    let headers = new HttpHeaders().set('Access-Control-Allow-Origin', `*`);
    return this.http.delete<Tasklist>(`${AppConfig.apiEndpoint}tasklist/delete/${(data.id)}`, data)  
  }
}
