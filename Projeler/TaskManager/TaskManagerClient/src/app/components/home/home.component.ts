import { Component } from '@angular/core';
import { SharedModule } from '../../modules/shared.module';
import { HttpService } from '../../services/http.service';
import { UserModel } from '../../models/user.model';
import { TaskModel } from '../../models/task.model';
import { NgForm } from '@angular/forms';
import { NgxDropzoneModule } from 'ngx-dropzone';
import { SwalService } from '../../services/swal.service';
import { HttpErrorResponse } from '@angular/common/http';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [SharedModule, NgxDropzoneModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css',
  providers: [DatePipe]
})
export class HomeComponent {

  users?: UserModel[];
  addModel: TaskModel = new TaskModel();

  constructor(private http: HttpService, private swal: SwalService, private datePipe: DatePipe) {
    this.getUsers();
    this.addModel.finishDate = this.datePipe.transform(new Date(), 'yyyy-MM-dd');
  }

  getUsers() {
    this.http.post<UserModel[]>("Users/GetAll", {}, (res) => {
      this.users = res;
      console.log("users", res);
    });
  }

  setTaskFile(event: any) {
    console.log(event);
    this.addModel.taskFile = event.addedFiles;
  }

  removeTaskFile(event: any) {
    this.addModel.taskFile.splice(this.addModel.taskFile.indexOf(event), 1);
  }

  saveUserIdForAddModel(id: string) {
    console.log(id);
    this.addModel.userId = id;
  }

  add(form: NgForm) {
    if (form.valid) {

      if (this.addModel.title === "") {
        this.swal.callToast("Bir Başlık Giriniz", "warning");
        return;
      }

      if (this.addModel.description === "") {
        this.swal.callToast("Bir Açıklama Giriniz", "warning");
        return;
      }

      if (this.addModel.finishDate === "") {
        this.swal.callToast("Bir Tarih Seçiniz", "warning");
        return;
      }
      //Validation Check

      //FormData oluşturma
      const formData = new FormData();
      formData.append("title", this.addModel.title);
      formData.append("description", this.addModel.description);
      formData.append("finishDateString", this.addModel.finishDate ?? "");
      formData.append("userId", this.addModel.userId);

      if (this.addModel.taskFile !== null) {
        for (let taskfile of this.addModel.taskFile) {
          formData.append("files", taskfile, taskfile.name);
        }
      }

      this.http.post<string>('TaskManagers/Create', formData, (res) => {
        console.log(res);
      });


    }

  }
}
