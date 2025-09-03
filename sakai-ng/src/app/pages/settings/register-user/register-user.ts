import { Component } from '@angular/core';
import { AuthService } from '@/services/auth.service';
import { Router } from '@angular/router';
import { MessageService } from 'primeng/api';
import { FormsModule } from '@angular/forms';
import { FluidModule } from 'primeng/fluid';
import { InputTextModule } from 'primeng/inputtext';
import { ButtonModule } from 'primeng/button';
import { SelectModule } from 'primeng/select';
import { TextareaModule } from 'primeng/textarea';

@Component({
  selector: 'app-register-user',
  imports: [FormsModule, ButtonModule, FluidModule, InputTextModule, SelectModule, TextareaModule],
  providers: [MessageService],
  templateUrl: './register-user.html',
  styleUrl: './register-user.scss'
})
export class RegisterUser {
  userid: string = '';
  nama: string = '';
  email: string = '';
  password: string = '';
  loading: boolean = false;

  dropdownItems = [
    { label: 'Admin', value: 'admin' },
    { label: 'Operator', value: 'operator' }
  ];

  kdgroup: string = '';

  constructor(private authService: AuthService, private router: Router, private messageService: MessageService) { }

  register() {
    this.loading = true;
    this.authService.register({ userid: this.userid, nama: this.nama, email: this.email, password: this.password, kdgroup: this.kdgroup }).subscribe({
      next: (res) => {
        this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: res.message });
        this.router.navigate(['/management-user']);
      },
      error: (err) => {
        this.messageService.add({ severity: 'error', summary: 'Gagal', detail: err.error?.message || 'Registrasi gagal' });
      },
      complete: () => {
        this.loading = false;
      }
    });
  }
}
