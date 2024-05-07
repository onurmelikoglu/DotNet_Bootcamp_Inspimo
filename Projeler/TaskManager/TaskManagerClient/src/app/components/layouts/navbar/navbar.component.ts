import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {
  auth: any;

  constructor(private router: Router) { }

  logout(): void {
    localStorage.clear();
    this.router.navigateByUrl("/login");
  }

}
