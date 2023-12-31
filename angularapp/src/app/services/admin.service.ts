import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import {Player} from '../../models/player.model'
import {Team} from '../../models/team.model';

@Injectable({
  providedIn: 'root'
})
export class AdminService {
  private url= "https://8080-aafccbeeebdefacbbecabcdadeafbbdcaeafe.premiumproject.examly.io/Admin";

  constructor(private httpclient: HttpClient) { }

  getPlayers():Observable<any[]>
  {
    return this.httpclient.get<any[]>(this.url + '/GetPlayer');
  }

  Details(id:number):Observable<Player>
  {
    return this.httpclient.get<Player>(this.url +'/GetPlayer/' + id);
  }

  AddPlayer(playerdata:Player):Observable<Player>{
    return this.httpclient.post<Player>(this.url+'/AddPlayer',playerdata, this.httpOptions);
  }

  editPlayer(playerdata: Player):Observable<Player>{
    return this.httpclient.put<Player>(this.url+'/EditPlayer/' + playerdata.id, playerdata,this.httpOptions); 
  }

  deletePlayer(id: number):Observable<Player>{
    return this.httpclient.delete<Player>(this.url+'/DeletePlayer/' + id)
  }

  
  getTeam():Observable<Team[]>
  {
    return this.httpclient.get<Team[]>(this.url+ '/GetTeams')
  }
 
  findTeam(id:number):Observable<Team>
  {
    return this.httpclient.get<Team>(this.url+'/DisplayTeams/'+id)
  }

  httpOptions= {headers:new HttpHeaders({'Content-type':'application/json'})}
  createTeam(teamdata:Team):Observable<Team>
  {
    return this.httpclient.post<Team>(this.url+'/AddTeam',teamdata,this.httpOptions)
  }
 
  editTeam(teamdata:Team):Observable<Team>
  {
    return this.httpclient.put<Team>(this.url+'/EditTeam/'+teamdata.id,teamdata,this.httpOptions)
  }
 
  deleteTeam(id:number):Observable<Team>{
    return this.httpclient.delete<Team>(this.url+'/DeleteTeam/'+id)
  }

  
}





