import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegisterComponent } from './register/register.component';
import { SearchComponent } from './search/search.component';
import { ProfileComponent } from './profile/profile.component';
import { NavbarComponent } from './navbar/navbar.component';
import { LoginComponent } from './login/login.component';
import { GroupinfoComponent } from './groupinfo/groupinfo.component';
import { FriendinfoComponent } from './friendinfo/friendinfo.component';
import { FilluserinfoComponent } from './filluserinfo/filluserinfo.component';
import { DeleteCheckComponent } from './delete-check/delete-check.component';
import { ChatlistComponent } from './chatlist/chatlist.component';
import { ChatComponent } from './chat/chat.component';
import { ChannelCreateComponent } from './channel-create/channel-create.component';
import { AddmemberComponent } from './addmember/addmember.component';
import { DatePipe } from './date.pipe';

@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    SearchComponent,
    ProfileComponent,
    NavbarComponent,
    LoginComponent,
    GroupinfoComponent,
    FriendinfoComponent,
    FilluserinfoComponent,
    DeleteCheckComponent,
    ChatlistComponent,
    ChatComponent,
    ChannelCreateComponent,
    AddmemberComponent,
    DatePipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
