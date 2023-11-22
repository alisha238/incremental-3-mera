import { Component, OnInit } from '@angular/core';
import { AdminService } from '../services/admin.service';
import { Router } from '@angular/router';
import {Player} from '../models/player';

@Component({
  selector: 'app-addplayer',
  templateUrl: './addplayer.component.html',
  styleUrls: ['./addplayer.component.css']
})
export class AddplayerComponent implements OnInit {
  playerdata: Player ={id:0,name:'',age:0, category:'',biddingprice:0, teamId:0}

  constructor(private as: AdminService, private route:Router) { }
  saveData(player: Player):void{
    this.playerdata= player
    this.as.AddPlayer(this.playerdata).subscribe(
      ()=>{
        alert('Record added successfully')
        this.route.navigate(['/getplayers'])
      }
    )
  }

  ngOnInit(): void {
  }

}
