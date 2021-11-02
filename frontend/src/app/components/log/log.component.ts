import {Component, OnInit} from '@angular/core';
import {NotifierService} from "../../services/notifier.service";

@Component({
  selector: 'app-log',
  templateUrl: './log.component.html',
  styleUrls: ['./log.component.scss']
})
export class LogComponent implements OnInit {
  logs: string[] = [];

  constructor(private notifierService: NotifierService) {
  }

  ngOnInit(): void {
    this.notifierService.listen().subscribe(x => this.logs.push(x));
  }

}
