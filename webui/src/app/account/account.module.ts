import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { AccountRoutingModule } from './account-routing.module';
import { YouTubePlayerModule } from "@angular/youtube-player";

import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { VerifyEmailComponent } from './verify-email/verify-email.component';
import { ForgotPasswordComponent } from './forgot-password/forgot-password.component';
import { ResetPasswordComponent } from './reset-password/reset-password.component';
import { LayoutComponent } from './layout/layout.component';
import { RegisterProComponent } from './register-pro/register-pro.component';



@NgModule({
  declarations: [
    LoginComponent,
    RegisterComponent,
    VerifyEmailComponent, 
    ForgotPasswordComponent, 
    ResetPasswordComponent, 
    LayoutComponent, RegisterProComponent],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    AccountRoutingModule,
    YouTubePlayerModule
  ]
})
export class AccountModule { }
