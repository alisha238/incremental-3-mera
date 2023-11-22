import { Component, OnInit } from '@angular/core';
import { AdminService } from '../services/admin.service';
import { Player } from '../models/player';
import { ActivatedRoute, Route, Router } from '@angular/router';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {
  playerdata: Player={id: 0, name: '', age:0, category: '',biddingprice: 0,teamId:0}

  constructor(private as: AdminService,private route: Router, private ar: ActivatedRoute ) { }

  id: number
  ngOnInit(): void {
    const tid= this.ar.snapshot.paramMap.get('id')
  }

}
