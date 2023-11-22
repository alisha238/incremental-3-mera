import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import {Player} from '../models/player'

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
}






// import { HttpClient, HttpHeaders } from '@angular/common/http';
// import { Injectable } from '@angular/core';
// import { Observable } from 'rxjs';
// import { IPlayer } from '../models/iplayer';
// import { ReturnStatement } from '@angular/compiler';

// @Injectable({
//   providedIn: 'root'
// })
// export class AdminServiceService {
//   private url:"https://8080-aafccbeeebdefacbbecabcdadeafbbdcaeafe.premiumproject.examly.io/Admin";

//   constructor(private httpclient: HttpClient) { }


//   GetAllPlayers():Observable <any[]>
//   {
//     return this.httpclient.get<any[]>(this.url + '/GetPlayer');
//   }


//   GetPlayer(id:number):Observable<IPlayer>
//   {
//     return this.httpclient.get<IPlayer>(this.url + '/GetPlayer/' +id);
//   }

//   httpOptions ={headers:new HttpHeaders({'Content-type':'application/json'})}
//   addplayer(playerdata:IPlayer):Observable <IPlayer>
//   {
//     return this.httpclient.post<IPlayer>(this.url + '/AddPlayer',playerdata,this.httpOptions);
//   }

//   editplayer(playerdata:IPlayer):Observable<IPlayer>
//   {
//     return this.httpclient.put<IPlayer>(this.url + '/EditPlayer' + playerdata.id, playerdata, this.httpOptions);
//   }
// }
