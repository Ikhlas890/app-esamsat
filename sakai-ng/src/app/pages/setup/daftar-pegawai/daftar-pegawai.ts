import { Component, OnInit } from '@angular/core';
import { Masterpegawai, MasterpegawaiService } from '@/services/masterpegawai.service';
import { Masterupt, MasteruptService } from '@/services/masterupt.service';
import { Masterktp, MasterktpService } from '@/services/masterktp.service';
import { ConfirmationService, MessageService } from 'primeng/api';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CardModule } from 'primeng/card';
import { ButtonModule } from 'primeng/button';
import { IconFieldModule } from 'primeng/iconfield';
import { InputIconModule } from 'primeng/inputicon';
import { TableModule } from 'primeng/table';
import { DialogModule } from 'primeng/dialog';
import { InputTextModule } from 'primeng/inputtext';
import { SelectModule } from 'primeng/select';
import { RadioButtonModule } from 'primeng/radiobutton';
import { ToastModule } from 'primeng/toast';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { AutoCompleteModule } from 'primeng/autocomplete';

@Component({
  selector: 'app-daftar-pegawai',
  imports: [
    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    CardModule,
    ButtonModule,
    IconFieldModule,
    InputIconModule,
    TableModule,
    DialogModule,
    InputTextModule,
    SelectModule,
    RadioButtonModule,
    ToastModule,
    ConfirmDialogModule,
    AutoCompleteModule
  ],
  providers: [ConfirmationService, MessageService],
  templateUrl: './daftar-pegawai.html',
  styleUrl: './daftar-pegawai.scss'
})
export class DaftarPegawai implements OnInit {
  // Daftar pegawai (masterpegawai)
  masterpegawaiList: Masterpegawai[] = [];
  selectedMasterpegawai: Masterpegawai = this.getEmptyMasterpegawai();
  masterpegawaiDialog = false;
  masterpegawaiEdit = false;

  masteruptOptions: { label: string; value: number | null }[] = [];
  masterktpOptions: { label: string; value: number | null }[] = [];
  filteredKtp: { label: string; value: number }[] = [];

  loadingDaftar = false;

  constructor(
    private masterpegawaiService: MasterpegawaiService,
    private masteruptService: MasteruptService,
    private masterktpService: MasterktpService,
    private messageService: MessageService,
    private confirmationService: ConfirmationService
  ) { }

  ngOnInit(): void {
    this.loadDaftar();
    this.loadMasterUpt();
    this.loadMasterKtp();
  }

  // ==== Daftar Entitas CRUD ====
  getEmptyMasterpegawai(): Masterpegawai {
    return {
      idktp: null,
      nip: '',
      nik: '',
      nama: '',
      idupt: null,
      nmupt: '',
      status: '',
      jabatan: '',
      pangkat: '',
      golongan: '',
      uid: '',
      telepon: '',
      createby: ''
    } as Masterpegawai; // jangan set idrekd di sini!
  }

  statusOptions = [
    { label: 'Aktif', value: '1' },
    { label: 'Tidak Aktif', value: '0' }
  ];

  getStatusLabel(value: string): string {
    const found = this.statusOptions.find(opt => opt.value === value);
    return found ? found.label : '-';
  }

  getNmUptLabel(value: number): string {
    const found = this.masteruptOptions.find(opt => opt.value === value);
    return found ? found.label : '-';
  }

  loadDaftar(): void {
    this.loadingDaftar = true;
    this.masterpegawaiService.getAll().subscribe({
      next: (data) => {
        this.masterpegawaiList = data;
        this.loadingDaftar = false;
      },
      error: (err) => {
        console.error('Gagal memuat daftar', err);
        this.loadingDaftar = false;
      }
    });
  }

  loadMasterUpt(): void {
    this.masteruptService.getAll().subscribe((data: Masterupt[]) => {
      this.masteruptOptions = [
        { label: '--- Pilih UPT ---', value: null },
        ...data.map(upt => ({
          label: upt.nmupt,
          value: upt.idupt
        }))
      ];
    });
  }

  loadMasterKtp(): void {
    this.masterktpService.getAll().subscribe((data: Masterktp[]) => {
      this.masterktpOptions = [
        ...data.map(ktp => ({
          label: ktp.nama,
          value: ktp.idktp
        }))
      ];
    });
  }

  searchReknrc(event: any) {
    const query = event.query;
    this.masterktpService.getForSelect(query).subscribe(data => {
      this.filteredKtp = data.map(r => ({ label: r.nama, value: r.idktp }));
    });
  }

  openNewDaftar(): void {
    this.selectedMasterpegawai = this.getEmptyMasterpegawai();
    this.masterpegawaiDialog = true;
    this.masterpegawaiEdit = false;
  }

  editDaftar(item: Masterpegawai): void {
    this.selectedMasterpegawai = { ...item };
    this.masterpegawaiDialog = true;
    this.masterpegawaiEdit = true;
  }

  saveDaftar(): void {
    const payload: any = {
      idktp: this.selectedMasterpegawai.idktp ?? null,
      nip: this.selectedMasterpegawai.nip || '',
      nik: this.selectedMasterpegawai.nik || '',
      nama: this.selectedMasterpegawai.nama || '',
      idupt: this.selectedMasterpegawai.idupt ?? null,
      status: this.selectedMasterpegawai.status || '1',
      jabatan: this.selectedMasterpegawai.jabatan?.trim() || '',
      pangkat: this.selectedMasterpegawai.pangkat || '',
      golongan: this.selectedMasterpegawai.golongan || '',
      uid: this.selectedMasterpegawai.uid || '',
      telepon: this.selectedMasterpegawai.telepon || ''

    };

    if (this.masterpegawaiEdit) {
      // update
      payload.updateby = 'admin'; // user login seharusnya diambil dari auth
      this.masterpegawaiService.update(this.selectedMasterpegawai.idpegawai!, payload).subscribe({
        next: () => {
          this.loadDaftar();
          this.masterpegawaiDialog = false;
          this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'Data berhasil diperbarui' });
        },
        error: (err) => {
          console.error('Gagal update data', err);
          this.messageService.add({ severity: 'error', summary: 'Gagal', detail: 'Terjadi kesalahan saat memperbarui data' });
        }
      });
    } else {
      // create
      payload.createby = 'admin'; // user login seharusnya diambil dari auth
      this.masterpegawaiService.create(payload).subscribe({
        next: () => {
          this.loadDaftar();
          this.masterpegawaiDialog = false;
          this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'Data berhasil ditambahkan' });
        },
        error: (err) => {
          console.error('Gagal create data', err);
          this.messageService.add({ severity: 'error', summary: 'Gagal', detail: 'Terjadi kesalahan saat menambahkan data' });
        }
      });
    }
  }

  confirmDeleteDaftar(item: Masterpegawai): void {
    this.confirmationService.confirm({
      message: `Yakin ingin menghapus daftar pegawai <b>${item.nama}</b>?`,
      header: 'Konfirmasi Hapus',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        this.masterpegawaiService.delete(item.idpegawai).subscribe({
          next: () => {
            this.masterpegawaiList = this.masterpegawaiList.filter(p => p.idpegawai !== item.idpegawai);
            this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'Daftar pegawai telah dihapus' });
          },
          error: () => {
            this.messageService.add({ severity: 'error', summary: 'Gagal', detail: 'Gagal menghapus daftar pegawai' });
          }
        });
      }
    });
  }
}
