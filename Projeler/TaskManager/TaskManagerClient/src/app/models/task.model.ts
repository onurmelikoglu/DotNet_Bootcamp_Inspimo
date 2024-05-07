export class TaskModel {
    id: string = "";
    userId: string = "";
    userName: string = "";
    title: string = "";
    description: string = "";
    finishDate: string | null = "";
    taskFileUrls: string[] = [];
    taskFile: any | null = null;
}