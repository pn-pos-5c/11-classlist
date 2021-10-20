import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import Clazz from "../models/Clazz";
import Student from "../models/Student";

@Injectable({
  providedIn: 'root'
})
export class DataProviderService {

  private baseUrl = "http://localhost:5000/api";

  constructor(private http: HttpClient) {
  }

  public getClazzes(): Observable<Clazz[]> {
    return this.http.get<Clazz[]>(`${this.baseUrl}/clazzes`);
  }

  public getStudentsForClazz(clazzId: number): Observable<Student[]> {
    return this.http.get<Student[]>(`${this.baseUrl}/students/${clazzId}`);
  }

  /*
  public setAge(studentId: number, age: number): Observable<Student> {
    return this.http.put<Student>(`${this.baseUrl}?studentId=${studentId}&age=${age}`);
  }
   */
}
