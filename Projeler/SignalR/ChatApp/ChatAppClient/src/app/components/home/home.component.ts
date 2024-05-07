import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { UserModel } from '../../models/user.model';
import { HttpClient } from '@angular/common/http';

import * as signalR from '@microsoft/signalr';
import { AuthService } from '../../guards/auth.service';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {

  users: UserModel[] = [];
  chats: ChatModel[] = [];
  selectedUserId: number = 0;
  selectedUser: UserModel = new UserModel();
  hub: signalR.HubConnection | undefined;

  constructor(private http: HttpClient, private auth: AuthService) {
    this.getAllUsers();

    this.hub = new signalR.HubConnectionBuilder()
      .withUrl("http://localhost:5044/chat-hub")
      .build();

    this.hub.start().then(() => {
      console.log("Connection started");
      this.hub?.invoke("Connect", this.auth.user.id);
      this.hub?.on("Users", (res: UserModel) => {
        const user = this.users.find(p => p.id === res.id);
        user!.status = res.status;
      });
    });
  }

  getAllUsers() {
    this.http.get<UserModel[]>('http://localhost:5044/api/Users/GetAll').subscribe(res => {
      console.log(res);
      this.users = res;
    })
  }


  changeUser(user: UserModel) {
    this.selectedUserId = user.id;
    this.selectedUser = user;
  }

}

export class ChatModel {
  userId: number = 0;
  toUserId: number = 0;
  date: string = "";
  message: string = "";
}


