import { Component, OnInit } from '@angular/core';
import { MessageService, ConfirmationService } from 'primeng/api';
import { AppgroupuserService, AppGroupUser } from '@/services/appgroupuser.service';
import { TableModule } from 'primeng/table';
import { DialogModule } from 'primeng/dialog';
import { ToastModule } from 'primeng/toast';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { ButtonModule } from 'primeng/button';
import { InputTextModule } from 'primeng/inputtext';
import { TextareaModule } from 'primeng/textarea';
import { FluidModule } from 'primeng/fluid';
import { SelectModule } from 'primeng/select';
import { CardModule } from 'primeng/card';

@Component({
  selector: 'app-appgroupuser',
  imports: [FormsModule, CommonModule, TableModule, DialogModule, ToastModule, ConfirmDialogModule, ButtonModule, InputTextModule, TextareaModule, FluidModule, SelectModule, CardModule],
  providers: [MessageService, ConfirmationService],
  templateUrl: './appgroupuser.html',
  styleUrl: './appgroupuser.scss'
})
export class Appgroupuser implements OnInit {
// Daftar kelompok user
groupList: AppGroupUser[] = [];

// Data yang sedang dibuat/diubah
currentGroup: AppGroupUser = this.createEmptyGroup();

groupDialog = false;
isEdit = false;

constructor(
  private groupService: AppgroupuserService,
  private messageService: MessageService,
  private confirmationService: ConfirmationService
) {}

ngOnInit(): void {
  this.loadGroups();
}

loadGroups(): void {
  this.groupService.getAll().subscribe(data => (this.groupList = data));
}

createEmptyGroup(): AppGroupUser {
  return { kdgroup: '', nmgroup: '', ket: '' };
}

openNew(): void {
  this.currentGroup = this.createEmptyGroup();
  this.isEdit = false;
  this.groupDialog = true;
}

editGroup(group: AppGroupUser): void {
  this.currentGroup = { ...group };
  this.isEdit = true;
  this.groupDialog = true;
}

deleteGroup(group: AppGroupUser): void {
  this.confirmationService.confirm({
    message: `Yakin ingin menghapus kelompok <b>${group.nmgroup}</b>?`,
    header: 'Konfirmasi',
    icon: 'pi pi-exclamation-triangle',
    accept: () => {
      this.groupService.delete(group.kdgroup).subscribe(() => {
        this.groupList = this.groupList.filter(g => g.kdgroup !== group.kdgroup);
        this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'Kelompok dihapus' });
      });
    }
  });
}

isFormValid(): boolean {
  return !!this.currentGroup.nmgroup?.trim() && (this.isEdit || !!this.currentGroup.kdgroup?.trim());
}

saveGroup(): void {
  if (!this.isFormValid()) return;

  const payload = this.currentGroup;
  const request$ = this.isEdit
    ? this.groupService.update(payload.kdgroup, payload)
    : this.groupService.create(payload);

  request$.subscribe(() => {
    this.loadGroups();
    this.messageService.add({
      severity: 'success',
      summary: 'Berhasil',
      detail: this.isEdit ? 'Kelompok diperbarui' : 'Kelompok ditambahkan'
    });
    this.groupDialog = false;
  });
}

hideDialog(): void {
  this.groupDialog = false;
  this.currentGroup = this.createEmptyGroup();
}
}
