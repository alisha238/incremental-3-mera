import { Component, OnInit } from '@angular/core';
import { AdminService } from '../services/admin.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Player } from '../../models/player';
// import { AdminService } from '../services/admin.service';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnInit {

  constructor(private as: AdminService, private ar: ActivatedRoute, private route: Router) { }

  playerdata :Player
  id: number
  
  ngOnInit() :void{
    const tid = this.ar.snapshot.paramMap.get('id')
    this.id = Number(tid)

    this.as.Details(this.id).subscribe((data: Player)=>{
      this.playerdata= data
    })
  }

}
