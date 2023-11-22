import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { GetplayersComponent } from './getplayers/getplayers.component';
import { HttpClientModule } from '@angular/common/http';
import { AddplayerComponent } from './addplayer/addplayer.component';
import { FormsModule } from '@angular/forms';
import { MenuComponent } from './menu/menu.component';
import { EditComponent } from './edit/edit.component';
import { DetailsComponent } from './details/details.component';
import { EditPlayerComponent } from './edit-player/edit-player.component';
import { DeletePlayerComponent } from './delete-player/delete-player.component';
import { DisplayTeamComponent } from './display-team/display-team.component';
import { HomeComponent } from './home/home.component';
import { TeamlistComponent } from './teamlist/teamlist.component';

@NgModule({
  declarations: [
    AppComponent,
    GetplayersComponent,
    AddplayerComponent,
    MenuComponent,
    EditComponent,
    DetailsComponent,
    EditPlayerComponent,
    DeletePlayerComponent,
    DisplayTeamComponent,
    HomeComponent,
    TeamlistComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
