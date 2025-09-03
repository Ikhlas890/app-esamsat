import { Component, OnInit } from '@angular/core';
import { AuthService, UserResponse } from '@/services/auth.service';
import { ConfirmationService, MessageService } from 'primeng/api';
import { TableModule } from "primeng/table";
import { CardModule } from 'primeng/card';
import { DatePipe } from '@angular/common';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { ToastModule } from 'primeng/toast';
import { ButtonModule } from 'primeng/button';
import { DialogModule } from 'primeng/dialog';
import { InputTextModule } from 'primeng/inputtext';
import { SelectModule } from 'primeng/select';
import { FormsModule } from '@angular/forms';
import { PasswordModule } from 'primeng/password';

@Component({
  selector: 'app-management-user',
  imports: [
    TableModule,
    PasswordModule,
    CardModule,
    DatePipe,
    ConfirmDialogModule,
    ToastModule,
    ButtonModule,
    DialogModule,
    InputTextModule,
    SelectModule,
    FormsModule
  ],
  providers: [ConfirmationService, MessageService],
  templateUrl: './management-user.html',
  styleUrl: './management-user.scss'
})
export class ManagementUser implements OnInit {
  users: UserResponse[] = [];
  loading = false;
  editDialogVisible = false;
  selectedUser: UserResponse = {} as UserResponse;

  dropdownItems = [
    { label: 'Admin', value: 'admin' },
    { label: 'Operator', value: 'operator' }
  ];

  constructor(
    private authService: AuthService,
    private confirmationService: ConfirmationService,
    private messageService: MessageService
  ) { }

  ngOnInit() {
    this.loadUsers();
  }

  loadUsers() {
    this.loading = true;
    this.authService.getUsers().subscribe({
      next: (data) => {
        this.users = data;
        this.loading = false;
      },
      error: () => {
        this.loading = false;
        this.messageService.add({ severity: 'error', summary: 'Gagal', detail: 'Tidak dapat memuat data user' });
      }
    });
  }

  confirmDelete(user: UserResponse) {
    this.confirmationService.confirm({
      message: `Yakin ingin menghapus user <b>${user.userid}</b>?`,
      header: 'Konfirmasi Hapus',
      icon: 'pi pi-exclamation-triangle',
      accept: () => this.deleteUser(user.userid)
    });
  }

  deleteUser(userid: string) {
    this.authService.deleteUser(userid).subscribe({
      next: () => {
        this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'User telah dihapus' });
        this.loadUsers();
      },
      error: () => {
        this.messageService.add({ severity: 'error', summary: 'Gagal', detail: 'Gagal menghapus user' });
      }
    });
  }

  openEditDialog(user: UserResponse) {
    this.selectedUser = { ...user }; // clone agar tidak langsung mengubah data tabel
    this.editDialogVisible = true;
  }

  saveUser() {
  if (this.selectedUser) {
    const payload: any = {
      nama: this.selectedUser.nama,
      email: this.selectedUser.email,
      kdgroup: this.selectedUser.kdgroup
    };

    if (this.selectedUser.password?.trim()) {
      payload.password = this.selectedUser.password;
    }

    this.authService.updateUser(this.selectedUser.userid, payload).subscribe({
      next: () => {
        this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'User berhasil diperbarui' });
        this.loadUsers();
        this.editDialogVisible = false;
      },
      error: () => {
        this.messageService.add({ severity: 'error', summary: 'Gagal', detail: 'Gagal memperbarui user' });
      }
    });
  }
}

}
