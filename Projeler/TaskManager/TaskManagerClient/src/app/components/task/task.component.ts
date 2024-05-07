import { Component, OnInit } from '@angular/core';
import { SharedModule } from '../../modules/shared.module';
import { NgForm } from '@angular/forms';
import { UserModel } from '../../models/user.model';
import { TaskModel } from '../../models/task.model';
import { HttpService } from '../../services/http.service';
import { SwalService } from '../../services/swal.service';
import { DatePipe } from '@angular/common';
import { NgxDropzoneModule } from 'ngx-dropzone';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  imports: [SharedModule, NgxDropzoneModule],
  standalone: true,
  styleUrls: ['./task.component.css'],
  providers: [DatePipe]
})
export class TaskComponent implements OnInit {

  tasks?: TaskModel[];

  constructor(private http: HttpService, private swal: SwalService, private datePipe: DatePipe) {
    this.getUsers();
    // this.addModel.finishDate = this.datePipe.transform(new Date(), 'yyyy-MM-dd');
  }

  ngOnInit(): void {

  }

  getUsers() {
    this.http.post<TaskModel[]>("TaskManagers/GetAll", {}, (res) => {
      this.tasks = res;
      console.log("tasks", res);
    });
  }

}
