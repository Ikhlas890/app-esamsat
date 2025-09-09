import { Component, OnInit } from '@angular/core';
import { MessageService, ConfirmationService } from 'primeng/api';
import { AppgroupuserService, AppGroupUser } from '@/services/appgroupuser.service';
import { TableModule } from 'primeng/table';
import { DialogModule } from 'primeng/dialog';
import { ToastModule } from 'primeng/toast';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { ButtonModule } from 'primeng/button';
import { InputTextModule } from 'primeng/inputtext';
import { TextareaModule } from 'primeng/textarea';
import { FluidModule } from 'primeng/fluid';
import { SelectModule } from 'primeng/select';
import { CardModule } from 'primeng/card';
import { InputIconModule } from 'primeng/inputicon';
import { IconFieldModule } from 'primeng/iconfield';

@Component({
  selector: 'app-appgroupuser',
  imports: [FormsModule, CommonModule, ReactiveFormsModule, TableModule,
    DialogModule, ToastModule, ConfirmDialogModule, ButtonModule, InputTextModule, TextareaModule,
    FluidModule, SelectModule, CardModule, InputIconModule, IconFieldModule],
  providers: [MessageService, ConfirmationService],
  templateUrl: './appgroupuser.html',
  styleUrl: './appgroupuser.scss'
})
export class Appgroupuser implements OnInit {
  groupList: AppGroupUser[] = [];
  selectedGroup: AppGroupUser = this.createEmptyGroup();

  dropdownItems = [
    { label: 'Admin', value: 'admin' },
    { label: 'Operator', value: 'operator' }
  ];

  loading = false;
  groupDialog = false;
  isEdit = false;

  constructor(
    private groupService: AppgroupuserService,
    private messageService: MessageService,
    private confirmationService: ConfirmationService
  ) { }

  ngOnInit(): void {
    this.loadGroups();
  }

  private createEmptyGroup(): AppGroupUser {
    return { kdgroup: '', nmgroup: '', ket: '' };
  }

  loadGroups(): void {
    this.loading = true;
    this.groupService.getAll().subscribe({
      next: (data) => {
        this.groupList = data;
        this.loading = false;
      },
      error: () => {
        this.loading = false;
        this.messageService.add({
          severity: 'error',
          summary: 'Gagal',
          detail: 'Tidak dapat memuat data kelompok user'
        });
      }
    });
  }

  openNew(): void {
    this.selectedGroup = this.createEmptyGroup();
    this.isEdit = false;
    this.groupDialog = true;
  }

  editGroup(group: AppGroupUser): void {
    this.selectedGroup = { ...group };
    this.isEdit = true;
    this.groupDialog = true;
  }

  deleteGroup(group: AppGroupUser): void {
    this.confirmationService.confirm({
      message: `Yakin ingin menghapus kelompok <b>${group.nmgroup}</b>?`,
      header: 'Konfirmasi',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        this.groupService.delete(group.kdgroup).subscribe({
          next: () => {
            this.groupList = this.groupList.filter(g => g.kdgroup !== group.kdgroup);
            this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'Kelompok dihapus' });
          },
          error: () => {
            this.messageService.add({ severity: 'error', summary: 'Gagal', detail: 'Gagal menghapus kelompok' });
          }
        });
      }
    });
  }

  isFormValid(): boolean {
    return Boolean(this.selectedGroup.nmgroup?.trim()) &&
      (this.isEdit || Boolean(this.selectedGroup.kdgroup?.trim()));
  }

  saveGroup(): void {
  if (!this.isFormValid()) return;

  const sanitize = (text: string) =>
    text
      ?.replace(/\u00A0/g, ' ')  // ubah non-breaking space jadi spasi biasa
      .replace(/[\u200B-\u200D\uFEFF]/g, '') // hapus zero-width chars
      .trim();

  const payload: AppGroupUser = {
    kdgroup: this.selectedGroup.kdgroup ?? '',
    nmgroup: this.selectedGroup.nmgroup ?? '',
    ket: sanitize(this.selectedGroup.ket ?? '')
  };

  const request$ = this.isEdit
    ? this.groupService.update(payload.kdgroup!, payload)
    : this.groupService.create(payload);

  request$.subscribe({
    next: () => {
      this.loadGroups();
      this.messageService.add({
        severity: 'success',
        summary: 'Berhasil',
        detail: this.isEdit ? 'Kelompok diperbarui' : 'Kelompok ditambahkan'
      });
      this.groupDialog = false;
    },
    error: (err) => {
      console.error('API Error:', err); // Untuk debug detail error dari backend
      this.messageService.add({
        severity: 'error',
        summary: 'Gagal',
        detail: this.isEdit ? 'Gagal memperbarui kelompok' : 'Gagal menambahkan kelompok'
      });
    }
  });
}


  hideDialog(): void {
    this.groupDialog = false;
    this.selectedGroup = this.createEmptyGroup();
  }
}
