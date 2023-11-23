import { Component, OnInit } from '@angular/core';
import { AdminService } from '../services/admin.service';
import { Team } from '../../models/team';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-team',
  templateUrl: './create-team.component.html',
  styleUrls: ['./create-team.component.css']
})
export class CreateTeamComponent implements OnInit {

  teamdata:Team={teamId:0,teamName:''}
  constructor(private as:AdminService,private route:Router) { }
saveData(team:Team):void{
 
  this.teamdata=team
  this.as.addTeam(this.teamdata).subscribe(
    ()=>{
      alert('Record added sucessfully')
      this.route.navigate(['/ListTeams'])
    }
  )
  }
  ngOnInit(): void {
  }

}
