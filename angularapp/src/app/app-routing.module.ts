import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GetplayersComponent } from './getplayers/getplayers.component';
import { AddplayerComponent } from './addplayer/addplayer.component';
import { DetailsComponent } from './details/details.component';

const routes: Routes = [
  {path:'displayallplayers',component: GetplayersComponent},
  {path: 'addplayer',component:AddplayerComponent},
  {path:'GetPlayer/:id', component:DetailsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
