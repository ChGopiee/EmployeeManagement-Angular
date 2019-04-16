import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from '../Models/Employee';
import {HttpService} from '../Services/HttpService';
                                                                           


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'EmployeeManagementAngular';
  employees:Employee[];
  constructor(private httpService: HttpService, private router: Router) {
   
}
  ngOnInit(): void {
    //this.httpService.get("EmployeeManagement/Index").then((response) => {
    //  this.employees = response;
    //});

  }
}
