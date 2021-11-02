import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';
import {DataProviderService} from "../../services/data-provider.service";
import Clazz from "../../models/Clazz";

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {
  @Input() header: string = '';
  @Input() clazzes: Clazz[] = [];
  @Output() selected = new EventEmitter<number>();

  constructor(private dataProvider: DataProviderService) {
  }

  ngOnInit(): void {
    this.dataProvider.getClazzes().subscribe(resolve => this.clazzes = resolve);
  }

  clazzSelected(clazzId: number) {
    this.selected.emit(clazzId);
  }
}
