import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import {Player} from '../models/player'
import { Team } from '../models/team';

@Injectable({
  providedIn: 'root'
})
export class AdminService {
  private url= "https://8080-aafccbeeebdefacbbecabcdadeafbbdcaeafe.premiumproject.examly.io/Admin";

  constructor(private httpclient: HttpClient) { }

  GetAllPlayers():Observable<any[]>
  {
    return this.httpclient.get<any[]>(this.url + '/GetPlayer');
  }

  Details(id:number):Observable<Player>
  {
    return this.httpclient.get<Player>(this.url +'/GetPlayer/' + id);
  }

  httpOptions= {headers:new HttpHeaders({'Content-type':'application/json'})}
  AddPlayer(playerdata:Player):Observable<Player>{
    return this.httpclient.post<Player>(this.url+'/AddPlayer',playerdata, this.httpOptions);
  }

  editPlayer(playerdata: Player):Observable<Player>{
    return this.httpclient.put<Player>(this.url+'/EditPlayer/' + playerdata.id, playerdata,this.httpOptions); 
  }

  deletePlayer(id: number):Observable<Player>{
    return this.httpclient.delete<Player>(this.url+'/DeletePlayer/' + id)
  }

  GetAllTeams():Observable<any[]>
  {
    return this.httpclient.get<any[]>(this.url + '/GetTeams');
  }


  
}





