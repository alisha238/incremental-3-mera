import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { IPlayer } from '../models/iplayer';
import { ITeam } from '../models/iteam';


@Injectable({
  providedIn: 'root'
})
export class TeamserviceService {
  private url: "https://8080-aafccbeeebdefacbbecabcdadeafbbdcaeafe.premiumproject.examly.io/Admin"

  constructor(private httpclient:HttpClient) { }


  getAllPlayers():Observable<any[]>
  {
    return this.httpclient.get<any[]>(this.url + '/ListPlayers')
  }

  getMovie(id:number):Observable<IPlayer>
  {
    return this.httpclient.get<IMovie>(this.url + '/ListMovies/' + id).pipe(catchError(this.handleError))
  }

  httpOptions={headers:new HttpHeaders({'Content-type':'application/json'})}
  addMovie(moviedata:IMovie):Observable<IMovie>
  {
    return this.httpclient.post<IMovie>(this.url+'/AddMovie', moviedata, this.httpOptions).pipe(catchError(this.handleError))
  }

  editMovie(moviedata: IMovie):Observable<IMovie>
  {
    return this.httpclient.put<IMovie>(this.url+'/EditMovie/' +moviedata.id, moviedata, this.httpOptions).pipe(catchError(this.handleError))
  }

  deleteMovie(id: number):Observable<IMovie>
  {
    return this.httpclient.delete<IMovie>(this.url +'/DeleteMovie/' +id).pipe(catchError(this.handleError))
  }

  addDetails(detailsdata: IDetails):Observable<IDetails>{
    return this.httpclient.post<IDetails>(this.url2+'/AddMovieDetails', detailsdata,this.httpOptions).pipe(catchError(this.handleError))
  }

  handleError(error:HttpErrorResponse){
    var errmsg = error.status + '\n' + error.statusText +'\n' +error.error
    alert(errmsg)
    return throwError(errmsg)
  }

}
