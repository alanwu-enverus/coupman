import { Component, OnInit } from '@angular/core';
import { AccountService } from '@app/services/account.service';
import { Role } from '@app/models/role';
import { Account } from '@app/models/account';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent {
  Role = Role;
  account: Account;
  constructor(private accountService: AccountService, private router: Router) {
    this.accountService.account.subscribe(x => this.account = x);
  }

  logout() {
    this.accountService.logout();
    this.router.navigate(['/home'])
  }
}
