import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';
import Student from "../../models/Student";
import Clazz from "../../models/Clazz";
import {DataProviderService} from "../../services/data-provider.service";
import {NotifierService} from "../../services/notifier.service";

@Component({
  selector: 'app-student-row',
  templateUrl: './student-row.component.html',
  styleUrls: ['./student-row.component.scss']
})
export class StudentRowComponent implements OnInit {
  @Input() student!: Student;
  clazzes!: Clazz[];
  @Output() studentRemoved = new EventEmitter<number>();

  constructor(private dataProvider: DataProviderService, private notifierService: NotifierService) {
  }

  ngOnInit(): void {
    this.dataProvider.getClazzes().subscribe(resolve => this.clazzes = resolve.filter(clazz => clazz.id !== this.student.clazzId));
  }

  getAgeString(age: number): number {
    return Math.floor(age / 10) * 10;
  }

  updateAge() {
    this.dataProvider.setAge(this.student.id, this.student.age).subscribe();
  }

  setClazz(clazz: Clazz) {
    this.dataProvider.setClazz(this.student.id, clazz.id).subscribe();
    this.studentRemoved.emit(this.student.id);
    this.notifierService.notify(`${this.student.firstname} ${this.student.lastname} --> ${clazz.name}`);
  }

  setRegistered() {
    this.student.registered = !this.student.registered;
    this.dataProvider.setRegistered(this.student.id, this.student.registered).subscribe();
  }
}
