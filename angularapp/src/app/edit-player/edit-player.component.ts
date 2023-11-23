import { Component, OnInit } from '@angular/core';
import { AdminService } from '../services/admin.service';
import { Player } from '../../models/player';
import { ActivatedRoute, Route, Router } from '@angular/router';

@Component({
  selector: 'app-edit',
  templateUrl: './edit-player.component.html',
  styleUrls: ['./edit-player.component.css']
})
export class EditPlayerComponent implements OnInit {
  playerdata: Player={id: 0, name: '', age:0, category: '',biddingPrice: 0,teamId:0}

  constructor(private as: AdminService,private route: Router, private ar: ActivatedRoute ) { }

  id: number
  ngOnInit(): void {
    const tid= this.ar.snapshot.paramMap.get('id')
    this.id = Number(tid)
    this.Details(this.id)
  }

  Details(id:number){
    this.as.Details(id).subscribe((data:Player)=> this.playerdata= data)
  }
  saveData(player: Player){
    this.playerdata= player

    this.as.editPlayer(this.playerdata).subscribe(
      ()=>{
        alert("Record Edited")
        this.route.navigate(['/displayallplayers'])
      })
  }

}

