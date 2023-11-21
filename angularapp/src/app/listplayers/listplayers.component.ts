import { Component, OnInit } from '@angular/core';
import { AdminService } from '../services/admin-service.service';
 
@Component({
  selector: 'app-listplayers',
  templateUrl: './listplayers.component.html',
  styleUrls: ['./listplayers.component.css']
})
export class ListplayersComponent implements OnInit {
 
  playerdata: any[] = [
    {path: 'GetPlayer',Component:ListplayersComponent}
  ]
 
  constructor(private ps:AdminService) {
    this.ps.getAllPlayers().subscribe(data=>{this.playerdata.push(...data)})
    console.log(this.playerdata);
  }
 
  ngOnInit(): void {
  }
 
}