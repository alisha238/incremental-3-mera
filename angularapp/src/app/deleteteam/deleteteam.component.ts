import { Component, OnInit } from '@angular/core';
import { Team } from '../../models/team';
import { AdminService } from '../services/admin.service';
import { ActivatedRoute, Router } from '@angular/router';
 
@Component({
  selector: 'app-deleteteam',
  templateUrl: './deleteteam.component.html',
  styleUrls: ['./deleteteam.component.css']
})
export class DeleteteamComponent implements OnInit {
 
  constructor(private as:AdminService, private ar: ActivatedRoute, private route: Router) { }
  id : number
  teamdata:Team = {teamId:0,teamName:''}
 
  ngOnInit(): void {
    const tid=this.ar.snapshot.paramMap.get('id')
    this.id=Number(tid)
    this.getteam(this.id)
  }
  getteam(id:number)
  {
    this.as.findTeam(id).subscribe((data:Team)=>
    this.teamdata=data)
  }
 
  saveData(team:Team):void{
    this.teamdata=team
    this.as.deleteTeam(this.id).subscribe(()=>{
   alert("Record Deleted")
   this.route.navigate(['/ListTeams'])
  })
 
}
}