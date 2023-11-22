import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Team } from '../models/team';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TeamService {

  url:"https://8080-aafccbeeebdefacbbecabcdadeafbbdcaeafe.premiumproject.examly.io/Admin"

  constructor(private httpclient:HttpClient) { }

  getTeam():Observable<Team[]>
  {
    return this.httpclient.get<Team[]>(this.url+ '/GetTeams')
  }
 
  findTeam(id:number):Observable<Team>
  {
    return this.httpclient.get<Team>(this.url+'/DisplayTeams/'+id)
  }

  httpOptions= {headers:new HttpHeaders({'Content-type':'application/json'})}
  addTeam(teamdata:Team):Observable<Team>
  {
    return this.httpclient.post<Team>(this.url+'/AddTeam',teamdata,this.httpOptions)
  }
 
  editTeam(teamdata:Team):Observable<Team>
  {
    return this.httpclient.put<Team>(this.url+'/EditTeam/'+teamdata.teamId,teamdata,this.httpOptions)
  }
 
  deleteTeam(id:number):Observable<Team>{
    return this.httpclient.delete<Team>(this.url+'/DeleteTeam/'+id)
  }
}
