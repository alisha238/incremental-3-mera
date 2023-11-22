import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GetplayersComponent } from './getplayers/getplayers.component';
import { AddplayerComponent } from './addplayer/addplayer.component';

const routes: Routes = [
  {path:'displayallplayers',component: GetplayersComponent},
  {path: 'addplayer',component:AddplayerComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
