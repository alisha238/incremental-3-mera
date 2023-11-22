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

@NgModule({
  declarations: [
    AppComponent,
    GetplayersComponent,
    AddplayerComponent,
    MenuComponent,
    EditComponent,
    DetailsComponent
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
