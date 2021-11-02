import {Component} from '@angular/core';
import Clazz from "./models/Clazz";
import {DataProviderService} from "./services/data-provider.service";
import Student from "./models/Student";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  clazzes: Clazz[] = [];
  students: Student[] = [];

  constructor(private dataProvider: DataProviderService) {
  }

  ngOnInit(): void {
    this.dataProvider.getClazzes().subscribe(resolve => this.clazzes = resolve);
  }

  onClazzSelected(clazzId: number) {
    this.dataProvider.getStudentsForClazz(clazzId).subscribe(resolve => {
      this.students = resolve;
      console.log(this.students);
    });
  }

  updateStudents(studentId: number) {
    this.students = this.students.filter(student => student.id !== studentId);
  }
}
