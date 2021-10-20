import { Component, OnInit } from '@angular/core';
import { DataProviderService } from "../../services/data-provider.service";

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {

  constructor(private dataProvider: DataProviderService) {
  }

  ngOnInit(): void {
    this.dataProvider.getClazzes().subscribe(resolve => console.log(resolve));
    this.dataProvider.getStudentsForClazz(1).subscribe(resolve => console.log(resolve));
  }

}
