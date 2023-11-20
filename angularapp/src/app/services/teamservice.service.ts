import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { IPlayer } from '../models/iplayer';
import {catchError} from 'rxjs/operators';
// import { HttpErrorResponse } from '@angular/common/http';
 
@Injectable({
  providedIn: 'root'
})
export class AdminService {
 
 
  private url : "https://8080-aafccbeeebdefacbbecabcdadeafbbdcaeafe.premiumproject.examly.io/Admin";
  constructor(private httpclient:HttpClient) { }
 
 
 
  getAllPlayers():Observable <any[]>
  {
    return this.httpclient.get<any[]>(this.url + '/GetPlayer');
  }
 
  getPlayer(id:number):Observable<IPlayer>
  {
    return this.httpclient.get<IPlayer>(this.url + '/GetPlayer/' + id);
  }
 
  httpOptions = {headers:new HttpHeaders({'Content-type':'application/json'})}
  addPlayer(playerdata:IPlayer):Observable<IPlayer>{
    return this.httpclient.post<IPlayer>(this.url+'/AddPlayer',playerdata,this.httpOptions);
  }
 
  editPlayer(playerdata:IPlayer):Observable<IPlayer>
  {
    return this.httpclient.put<IPlayer>(this.url + '/EditPlayer/'+ playerdata.id,playerdata,this.httpOptions);
  }
  deletePlayer(id:number):Observable<IPlayer>
  {
    return this.httpclient.delete<IPlayer>(this.url + '/DeletePlayer/' + id);
  }
 
  // addDetails(detailsdata: Idetails) :Observable<Idetails>{
  //   return this.httpclient.post<Idetails>(this.url2 + '/AddMovieDetails',detailsdata, this.httpOptions).pipe(catchError(this.handleError));
  // }
 
  // handleError(error:HttpErrorResponse)
  // {
  //   var errmsg = error.status + '\n' + error.statusText + '\n' + error.error
  //   alert(errmsg)
  //   return throwError(errmsg)
  // }
}
