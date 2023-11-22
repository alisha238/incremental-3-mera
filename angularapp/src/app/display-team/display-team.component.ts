import {Component, OnInit } from '@angular/core';
import { AdminService } from '../services/admin.service';

@Component({
  selector: 'app-display-team',
  templateUrl: './display-team.component.html',
  styleUrls: ['./display-team.component.css']
})
export class DisplayTeamComponent implements OnInit {

  teamData: any[]=[]

  constructor(private as: AdminService) {
    this.as.getTeams().subscribe(data =>{this.teamData.push(...data)})
    console.log(this.teamData)
  }

  ngOnInit(): void {
  }

}


