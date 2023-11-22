import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-teamlist',
  templateUrl: './teamlist.component.html',
  styleUrls: ['./teamlist.component.css']
})
export class TeamlistComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  import { Component, OnInit } from '@angular/core';
  import { Team } from '../models/team';
  import { AdminService } from '../services/admin.service';
  import { ActivatedRoute,Route, Router } from '@angular/router';
   
  @Component({
    selector: 'app-teamslist',
    templateUrl: './teamslist.component.html',
    styleUrls: ['./teamslist.component.css']
  })
  export class TeamslistComponent implements OnInit {
  teamdata:any[]=[]
    constructor(private as:AdminService,ar:ActivatedRoute,route:Router) {
      this.as.getTeam().subscribe(data=>{this.teamdata.push(...data);
      })
     }
   
    ngOnInit(): void {
    }
   
  }
}
