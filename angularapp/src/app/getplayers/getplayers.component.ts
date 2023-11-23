import { Component, OnInit } from '@angular/core';
import { AdminService } from '../services/admin.service';

@Component({
  selector: 'app-getplayers',
  templateUrl: './getplayers.component.html',
  styleUrls: ['./getplayers.component.css']
})
export class GetplayersComponent implements OnInit {
  playerdata: any[]=[]

  constructor(private as:AdminService) {
    this.as.getPlayers().subscribe(data =>{this.playerdata.push(...data)})
    console.log(this.playerdata)
   }

  ngOnInit(): void {
  }

}
