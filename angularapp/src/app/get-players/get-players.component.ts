import { Component, OnInit } from '@angular/core';
import { AdminService } from '../services/admin.service';

@Component({
  selector: 'app-get-players',
  templateUrl: './get-players.component.html',
  styleUrls: ['./get-players.component.css']
})
export class GetPlayersComponent implements OnInit {
  playerdata: any[]=[]
  constructor(private as: AdminService) { 

  this.as.getPlayers().subscribe(data =>{this.playerdata.push(...data)})
  console.log(this.playerdata)
  }
  ngOnInit(): void {
  }

}
