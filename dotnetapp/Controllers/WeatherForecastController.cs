// // using Microsoft.AspNetCore.Mvc;

// // namespace dotnetapp.Controllers
// // {
// //     [ApiController]
// //     [Route("[controller]")]
// //     public class WeatherForecastController : ControllerBase
// //     {
// //         private static readonly string[] Summaries = new[]
// //         {
// //         "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
// //     };

// //         private readonly ILogger<WeatherForecastController> _logger;

// //         public WeatherForecastController(ILogger<WeatherForecastController> logger)
// //         {
// //             _logger = logger;
// //         }

// //         [HttpGet(Name = "GetWeatherForecast")]
// //         public IEnumerable<WeatherForecast> Get()
// //         {
// //             return Enumerable.Range(1, 5).Select(index => new WeatherForecast
// //             {
// //                 Date = DateTime.Now.AddDays(index),
// //                 TemperatureC = Random.Shared.Next(-20, 55),
// //                 Summary = Summaries[Random.Shared.Next(Summaries.Length)]
// //             })
// //             .ToArray();
// //         }
// //     }
// // }



// npx -p @angular/cli@8 ng new AngMovie


// Package.Json file
// "start": "ng serve --port 8081 --disable-host-check --host=0.0.0.0",

// ------------------------------------------------------
// Create interface:
// npx ng g interface model/IMovie
// npx ng g interface model/IDetail

// export interface IDetails {
//     detailid:number
//     actor:string
//     movieid:number
//     gender:string
//     role:string
//     // role?:string
    
// }

// -------------------------------------------

// Create service:
// npx ng g service services/movieservice

// ----------------------------

// install Bootstrap
// npx npm install bootstrap@4


// copy the path of bootstrap.min.css folder
// paste it in angular.json styles tag

// -----------------------------------------------
// add paths in app-routing.modules
// .
// const routes: Routes = [
//   {path:'displayallplayers',component: GetplayersComponent},
//   {path: 'addplayer',component:AddplayerComponent},
//   {path:'GetPlayer/:id', component:DetailsComponent},
//   {path: 'EditPlayer/:id', component:EditComponent},
//   {path:'DeletePlayer/:id', component:DeletePlayerComponent}
// ];


// --------------------------------------------------

// do the stylingin style.css

// ----------------------------------

// add the global routing in app-component.html

// <app-menu></app-menu>
// <router-outlet></router-outlet>

// ------------------------------
// in app-module.ts
// in both imports,BrowserModule, AppRoutingModule, HttpClientModule, FormsModule,ReactiveFormsModule

// -----------------------------------

// Add app.UseCors();
// in Program.cs of WebApi


// =======================================================================================================


// -------------------------
// SERvice

// import { Injectable } from '@angular/core';
// import {HttpClient, HttpHeaders} from '@angular/common/http';
// import { Observable } from 'rxjs';
// import {Player} from '../models/player'

// @Injectable({
//   providedIn: 'root'
// })
// export class AdminService {
//   private url= "https://8080-aafccbeeebdefacbbecabcdadeafbbdcaeafe.premiumproject.examly.io/Admin";

//   constructor(private httpclient: HttpClient) { }

//   GetAllPlayers():Observable<any[]>
//   {
//     return this.httpclient.get<any[]>(this.url + '/GetPlayer');
//   }

// ---------------

// Display ALL players Component

// import { Component, OnInit } from '@angular/core';
// import { AdminService } from '../services/admin.service';

// @Component({
//   selector: 'app-getplayers',
//   templateUrl: './getplayers.component.html',
//   styleUrls: ['./getplayers.component.css']
// })
// export class GetplayersComponent implements OnInit {
//   playerdata: any[]=[]

//   constructor(private as:AdminService) {
//     this.as.GetAllPlayers().subscribe(data =>{this.playerdata.push(...data)})
//     console.log(this.playerdata)
//    }

//   ngOnInit(): void {
//   }

// }

// ---------------

// Display All Player Html


// <div class ="container">
//     <div class="jumbotron">
//         <h1>List of all Players</h1>
//         <table class="table">
//             <thead>
//                 <th>Id</th>
//                 <th>Name</th>
//                 <th>Age</th>
//                 <th>Category</th>
//                 <th>Bidding Price</th>
//                 <th>Team Id</th>
//             </thead>

//             <tbody>
//                 <tr *ngFor ="let m of playerdata">
//                     <td>{{m.id}}</td>
//                     <td>{{m.name}}</td>
//                     <td>{{m.age}}</td>
//                     <td>{{m.category}}</td>
//                     <td>{{m.biddingPrice}}</td>
//                     <td>{{m.teamId}}</td>
//                     <td><a [routerLink] = "['/GetPlayer/',m.id]">Details</a></td> &nbsp;&nbsp;
//                     <td><a [routerLink] = "['/EditPlayer/',m.id]">Edit</a></td>&nbsp;&nbsp;
//                     <td><a [routerLink]="['/DeletePlayer/',m.id]"> Delete</a></td> &nbsp;&nbsp;
                   
//                 </tr>
//             </tbody>
//         </table>
//     </div>
// </div>


// =====================================================================================


// Get Player by Id/Details Service

// Details(id:number):Observable<Player>
//   {
//     return this.httpclient.get<Player>(this.url +'/GetPlayer/' + id);
//   }

// -------------------

// Details Component


// import { Component, OnInit } from '@angular/core';
// import { AdminService } from '../services/admin.service';
// import { ActivatedRoute, Router } from '@angular/router';
// import { Player } from '../models/player';
// // import { AdminService } from '../services/admin.service';

// @Component({
//   selector: 'app-details',
//   templateUrl: './details.component.html',
//   styleUrls: ['./details.component.css']
// })
// export class DetailsComponent implements OnInit {

//   constructor(private as: AdminService, private ar: ActivatedRoute, private route: Router) { }

//   playerdata :Player
//   id: number
  
//   ngOnInit() :void{
//     const tid = this.ar.snapshot.paramMap.get('id')
//     this.id = Number(tid)

//     this.as.Details(this.id).subscribe((data: Player)=>{
//       this.playerdata= data
//     })
//   }

// }

// ---------------------

// Details Html

// <p>details works!</p>
// <h3>Details of Movies {{playerdata.name}}</h3>
// <div style ="background-color: antiquewhite;">
// Id:{{playerdata.id}} <br>
// Name:{{playerdata.name}}<br>
// Age: {{playerdata.age}}<br>
// Category: {{playerdata.category}}<br>
// Bidding Price: {{playerdata.biddingPrice}}<br>
// Team Id: {{playerdata.teamId}}<br>
// </div>



// =====================================================================================


// Add Players Service


//   httpOptions= {headers:new HttpHeaders({'Content-type':'application/json'})}
//   AddPlayer(playerdata:Player):Observable<Player>{
//     return this.httpclient.post<Player>(this.url+'/AddPlayer',playerdata, this.httpOptions);
//   }

// -----------------------

// Add Player Component

// import { Component, OnInit } from '@angular/core';
// import { AdminService } from '../services/admin.service';
// import { Router } from '@angular/router';
// import {Player} from '../models/player';

// @Component({
//   selector: 'app-addplayer',
//   templateUrl: './addplayer.component.html',
//   styleUrls: ['./addplayer.component.css']
// })
// export class AddplayerComponent implements OnInit {
//   playerdata: Player ={id:0,name:'',age:0, category:'',biddingPrice:0, teamId:0}

//   constructor(private as: AdminService, private route:Router) { }
//   saveData(player: Player):void{
//     this.playerdata= player
//     this.as.AddPlayer(this.playerdata).subscribe(
//       ()=>{
//         alert('Record added successfully')
//         this.route.navigate(['/getplayers'])
//       }
//     )
//   }

//   ngOnInit(): void {
//   }

// }

// ----------------------

// Add Player HTml

// <h2>Add New Movie</h2>
// <hr>
// <form (ngSubmit)="saveData(playerdata)" #playerform = "ngForm">
//     <div>
//         <label for="name">Player Name</label>
//         <input type ="text" id="name" name="name" placeholder="Enter player name here"
//         [(ngModel)]="playerdata.name" required #name="ngModel">
//     </div>

//     <div>
//         <label for="age">Player Age</label>
//         <input type ="text" id="age" name="age" placeholder="Enter Age"
//         [(ngModel)]="playerdata.age" required #age="ngModel">
        
//     </div>

//     <div>
//         <label for="category">Category</label>
//         <input type ="text" id="category" name="category" placeholder="Enter Category"
//         [(ngModel)]="playerdata.category" required #name="ngModel">
//     </div>

//     <div>
//         <label for="biddingPrice">Bidding Price</label>
//         <input type ="text" id="biddingPrice" name="biddingPrice" placeholder="Enter Bidding Price"
//         [(ngModel)]="playerdata.biddingPrice" required #name="ngModel">
//     </div>

//     <div>
//         <label for="teamId">Team Id</label>
//         <input type ="text" id="teamId" name="teamId" placeholder="Enter Team Id"
//         [(ngModel)]="playerdata.teamId" required #name="ngModel">
//     </div>

//     <br>
//     <br>

//     <input type ="submit" value="Save" class ="btn btn-Info" [disabled] ="!playerform.valid">
// </form>



// =====================================================================================



// Edit PLayer Service

// editPlayer(playerdata: Player):Observable<Player>{
//     return this.httpclient.put<Player>(this.url+'/EditPlayer/' + playerdata.id, playerdata,this.httpOptions); 
//   }

// -----------------

// Edit Player Component


// import { Component, OnInit } from '@angular/core';
// import { AdminService } from '../services/admin.service';
// import { Player } from '../models/player';
// import { ActivatedRoute, Route, Router } from '@angular/router';

// @Component({
//   selector: 'app-edit',
//   templateUrl: './edit-player.component.html',
//   styleUrls: ['./edit-player.component.css']
// })
// export class EditPlayerComponent implements OnInit {
//   playerdata: Player={id: 0, name: '', age:0, category: '',biddingPrice: 0,teamId:0}

//   constructor(private as: AdminService,private route: Router, private ar: ActivatedRoute ) { }

//   id: number
//   ngOnInit(): void {
//     const tid= this.ar.snapshot.paramMap.get('id')
//     this.id = Number(tid)
//     this.Details(this.id)
//   }

//   Details(id:number){
//     this.as.Details(id).subscribe((data:Player)=> this.playerdata= data)
//   }
//   saveData(player: Player){
//     this.playerdata= player

//     this.as.editPlayer(this.playerdata).subscribe(
//       ()=>{
//         alert("Record Edited")
//         this.route.navigate(['/displayallplayers'])
//       })
//   }

// }

// -----------------------------
// Edit Player Html


// <p>edit-player works!</p>
// <p>edit works!</p>
// <h2>Editing Movie</h2>
// <hr>
// <form (ngSubmit)="saveData(playerdata)" #playerform = "ngForm">
//     <div>
//         <label for="id">Id</label>
//         <input type="text" id="id" name="id" readonly [(ngModel)]="playerdata.id">    
//     </div>
//     <div>
//         <label for="name">Player Name</label>
//         <input type ="text" id="name" name="name" placeholder="Enter player name here"
//         [(ngModel)]="playerdata.name" required #name="ngModel">
//     </div>

//     <div>
//         <label for="age">Player Age</label>
//         <input type ="text" id="age" name="age" placeholder="Enter Age"
//         [(ngModel)]="playerdata.age" required #age="ngModel">
        
//     </div>

//     <div>
//         <label for="category">Category</label>
//         <input type ="text" id="category" name="category" placeholder="Enter Category"
//         [(ngModel)]="playerdata.category" required #name="ngModel">
//     </div>

//     <div>
//         <label for="biddingPrice">Bidding Price</label>
//         <input type ="text" id="biddingPrice" name="biddingPrice" placeholder="Enter Bidding Price"
//         [(ngModel)]="playerdata.biddingPrice" required #name="ngModel">
//     </div>

//     <div>
//         <label for="teamId">Team Id</label>
//         <input type ="text" id="teamId" name="teamId" placeholder="Enter Team Id"
//         [(ngModel)]="playerdata.teamId" required #name="ngModel">
//     </div>

//     <br>
//     <br>

//     <input type ="submit" value="Save" class ="btn btn-Info" [disabled] ="!playerform.valid">
// </form>



// =====================================================================================



// Delete Player Service


// deletePlayer(id: number):Observable<Player>{
//     return this.httpclient.delete<Player>(this.url+'/DeletePlayer/' + id)
//   }
// }


// ------------------------


// Delete Player Component
// import { Component, OnInit } from '@angular/core';
// import { AdminService } from '../services/admin.service';
// import { ActivatedRoute, Router } from '@angular/router';
// import { Player } from '../models/player';

// @Component({
//   selector: 'app-delete-player',
//   templateUrl: './delete-player.component.html',
//   styleUrls: ['./delete-player.component.css']
// })
// export class DeletePlayerComponent implements OnInit {

//   constructor(private as: AdminService, private ar: ActivatedRoute, private route: Router) { }

//   id:number
//   playerdata: Player= {id:0, name:'',age:0, category:'',biddingPrice:0,teamId:0}
//   ngOnInit(): void {
//     const tid= this.ar.snapshot.paramMap.get('id')
//     this.id= Number(tid)
//     this.Details(this.id)
//   }
//   Details(id: number){
//     this.as.Details(id).subscribe((data : Player)=>
//     this.playerdata= data)}

//     saveData(player: Player): void{
//       this.playerdata = player
//       this.as.deletePlayer(this.id).subscribe(()=>
//       {
//         alert("Record Deleted")
//       })
//     }

// }

// -------------------------

// Delete Player Html



// <h2>Delete Player</h2>
// <hr>
// <form (ngSubmit)="saveData(playerdata)" #playerform="ngForm">
// <div>
// <label for="id">ID</label>
// <input type="text" id="id" name="id" readonly [(ngModel)]="playerdata.id">
// </div>
// <div>
// <label for="name">Player Name</label>
// <input type="text" id="name" name="name" readonly [(ngModel)]="playerdata.name">
// </div>
// <div>
// <label for="age">Age</label>
// <input type="text" id="age" name="age" placeholder="enter age"
//         [(ngModel)]="playerdata.age" required #age="ngModel">
// </div>
// <div>
// <label for="category">Category</label>
// <input type="text" id="category" name="category" readonly [(ngModel)]="playerdata.category" >
// </div>
// <div>
// <label for="biddingPrice">Bidding Price</label>
// <input type="text" id="biddingPrice" name="biddingPrice" readonly [(ngModel)]="playerdata.biddingPrice" >
// </div>
// <div>
// <label for="teamId"> Team ID</label>
// <input type="text" id="teamId" name="teamId"  readonly [(ngModel)]="playerdata.teamId" >
// </div>
// <br>
// <p>
// <input type="submit" value="Delete" class="btn btn-Info">
// </p>
// </form>


// =====================================================================================


// Menu Html

// <h1>Welcome to the Club</h1>
// <hr>
// <div>
//     <ul>
//         <li>
//             <a routerLink= "displayallplayers"> All Players</a>
//             &nbsp; &nbsp; &nbsp;
//             <a routerLink= "addplayer">Add Player</a>

            

//         </li>
//     </ul>
// </div>

// -------------------------------------------------------------

// Reactive Form to Add

// React form Component

// import { Component, OnInit } from '@angular/core';
// import { IMovie } from '../model/imovie';
// import { FormBuilder, Validators } from '@angular/forms';
// import { MovieserviceService } from '../services/movieservice.service';
// import { Router } from '@angular/router';

// @Component({
//   selector: 'app-react-form',
//   templateUrl: './react-form.component.html',
//   styleUrls: ['./react-form.component.css']
// })
// export class ReactFormComponent implements OnInit {
//   moviedata: IMovie


//   constructor(private fb:FormBuilder, private ms:MovieserviceService, private route: Router) { }
//   movieform = this.fb.group({
//     name: ['',Validators.required],
//     yearRelease: ['', [Validators.min(2000), Validators.max(2023)]],
//     rating: ['',[Validators.required, Validators.min(1), Validators.max(5)]]
//   })
//   saveData(): void{
//     this.moviedata = this.movieform.value
//     if(this.moviedata.rating > 5){
//       alert('error in rating')
//       return
//     }
//     console.log(this.moviedata)
//     this.ms.addMovie(this.moviedata).subscribe(
//       ()=>{
//         alert("Recor added")
//         this.route.navigate(['/listmovies'])
  
//       }
//     )
//   }
//   ngOnInit() {
//   }

// }

// --------------------------------------------------

// React Form Html

// <p>react-form works!</p>
// <h2>Adding Movie Data</h2>
// <hr>
// <form [formGroup]="movieform" (ngSubmit)='saveData()'>
//     <div class="container jumbotron" style="width: 500px;">
//             <div class="form-group">
//                 <label for="name">Your Name</label>
//                 <input type= "text" id="name" name="name" formControlName="name" class="form-control">
//             </div>

//             <div class="form-group">                                                                                                        
//                 <label for="year">Year</label>
//                 <input type= "text" id="year" name="year" formControlName="yearRelease" class="form-control">
//             </div>

//             <div class="form-group">
//                 <label for="rating">Rating</label>
//                 <input type= "text" id="rating" name="rating" formControlName="rating" class="form-control">
//             </div>
//                 <br>
//                 <br>
//                 <p>
//                     <button type ="submit" class="btn btn-info">Save</button>
//                 </p>
//     </div>

// </form>


