import { Component, OnInit } from '@angular/core';
import { AdminService } from '../services/admin.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Team } from '../../models/team';
 
@Component({
  selector: 'app-findteam',
  templateUrl: './findteam.component.html',
  styleUrls: ['./findteam.component.css']
})
export class FindteamComponent implements OnInit {
 
  constructor(private as:AdminService,private ar:ActivatedRoute,private router:Router) { }
teamdata:Team
id:number
  ngOnInit(): void {
 
    const tid=this.ar.snapshot.paramMap.get('id')
    this.id=Number(tid)
    this.as.findTeam(this.id).subscribe((data:Team) =>{
      this.teamdata=data;
    })
    // console.log(this.teamdata);
  }
 
  Show()
  {
    this.router.navigate(['/ListTeams'])
  }
 
}