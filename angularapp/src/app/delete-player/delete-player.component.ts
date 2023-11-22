import { Component, OnInit } from '@angular/core';
import { AdminService } from '../services/admin.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Player } from '../models/player';

@Component({
  selector: 'app-delete-player',
  templateUrl: './delete-player.component.html',
  styleUrls: ['./delete-player.component.css']
})
export class DeletePlayerComponent implements OnInit {

  constructor(private as: AdminService, private ar: ActivatedRoute, private route: Router) { }

  id:number
  playerdata: Player= {id:0, name:'',age:0, category:'',biddingPrice:0,teamId:0}
  ngOnInit(): void {
    const tid= this.ar.snapshot.paramMap.get('id')
    this.id= Number(tid)
    this.Details(this.id)
  }
  Details(id: number){
    this.as.Details(id).subscribe((data : Player)=>
    this.playerdata= data)}

    saveData(player: Player): void{
      this.playerdata = player
      this.as.deletePlayer(this.id).subscribe(()=>
      {
        alert("Record Deleted")
      })
    }

}
