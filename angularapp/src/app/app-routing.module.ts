import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GetplayersComponent } from './getplayers/getplayers.component';
import { AddplayerComponent } from './addplayer/addplayer.component';
import { DetailsComponent } from './details/details.component';
import { EditComponent } from './edit/edit.component';
import { DeletePlayerComponent } from './delete-player/delete-player.component';
import { TeamlistComponent } from './teamlist/teamlist.component';
import { FindteamComponent } from './findteam/findteam.component';
import { AddteamComponent } from './addteam/addteam.component';
import { EditteamComponent } from './editteam/editteam.component';
import { DeleteteamComponent } from './deleteteam/deleteteam.component';

const routes: Routes = [
  {path:'displayallplayers',component: GetplayersComponent},
  {path: 'addplayer',component:AddplayerComponent},
  {path:'GetPlayer/:id', component:DetailsComponent},
  {path: 'EditPlayer/:id', component:EditComponent},
  {path:'DeletePlayer/:id', component:DeletePlayerComponent},
  {path:'ListTeams',component:TeamlistComponent},
  {path:'DisplayTeams/:id',component:FindteamComponent},
  {path:'AddTeam',component:AddteamComponent},
  {path:'EditTeam/:id',component:EditteamComponent},
  {path:'DeleteTeam/:id',component:DeleteteamComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
