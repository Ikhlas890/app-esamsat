import { Component, OnInit, ViewChild } from '@angular/core';
import { Masterupt, MasteruptService } from '@/services/masterupt.service';
import { Masterpegawai, MasterpegawaiService } from '@/services/masterpegawai.service';
import { Masterbank, MasterbankService } from '@/services/masterbank.service';
import { Masterkabkotum, MasterkabkotumService } from '@/services/masterkabkotum.service';
import { ConfirmationService, MessageService } from 'primeng/api';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CardModule } from 'primeng/card';
import { ButtonModule } from 'primeng/button';
import { IconFieldModule } from 'primeng/iconfield';
import { InputIconModule } from 'primeng/inputicon';
import { TableModule, Table } from 'primeng/table';
import { DialogModule } from 'primeng/dialog';
import { InputTextModule } from 'primeng/inputtext';
import { SelectModule } from 'primeng/select';
import { RadioButtonModule } from 'primeng/radiobutton';
import { ToastModule } from 'primeng/toast';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { ToolbarModule } from 'primeng/toolbar';
import * as XLSX from 'xlsx';
import * as FileSaver from 'file-saver';
import { StyleClass } from "primeng/styleclass";


@Component({
  selector: 'app-daftar-entitas',
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
    ToolbarModule
],
  providers: [ConfirmationService, MessageService],
  templateUrl: './daftar-entitas.html',
  styleUrl: './daftar-entitas.scss'
})
export class DaftarEntitas implements OnInit {
  // Daftar entitas (masterupt)
  masteruptList: Masterupt[] = [];

  // Untuk multi-select di tabel
  selectedMasterupts: Masterupt[] = [];

  // untuk satu record aktif (object tunggal, di form/dialog).
  selectedMasterupt: Masterupt = this.getEmptyMasterupt();

  masteruptDialog = false;
  masteruptEdit = false;

  masterpegawaiOptions: { label: string; value: number | null }[] = [];
  masterbankOptions: { label: string; value: number | null }[] = [];
  masterkabkotumOptions: { label: string; value: number | null }[] = [];

  loadingDaftar = false;

  constructor(
    private masteruptService: MasteruptService,
    private masterpegawaiService: MasterpegawaiService,
    private masterkabkotumService: MasterkabkotumService,
    private masterbankService: MasterbankService,
    private messageService: MessageService,
    private confirmationService: ConfirmationService
  ) { }

  // Export data (Excel)
  @ViewChild('dt') dt!: Table;

  onGlobalFilter(table: Table, event: Event) {
    table.filterGlobal((event.target as HTMLInputElement).value, 'contains');
  }

  exportExcel() {
    // pilih data yg difilter, kalau tidak ada ambil semua
    const dataToExport = this.dt?.filteredValue || this.masteruptList;

    const worksheet = XLSX.utils.json_to_sheet(dataToExport);
    const workbook = { Sheets: { data: worksheet }, SheetNames: ['data'] };

    const excelBuffer: any = XLSX.write(workbook, { bookType: 'xlsx', type: 'array' });
    this.saveAsExcelFile(excelBuffer, 'daftar_upt');
  }

  private saveAsExcelFile(buffer: any, fileName: string): void {
    const data: Blob = new Blob([buffer], { type: 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;charset=UTF-8' });
    FileSaver.saveAs(data, `${fileName}.xlsx`);
  }
  // End export data (Excel)

  ngOnInit(): void {
    this.loadDaftar();
    this.loadMasterPegawai();
    this.loadMasterBank();
    this.loadMasterKabkotum();
  }

  // ==== Daftar Entitas CRUD ====
  getEmptyMasterupt(): Masterupt {
    return {
      idparent: null, // biarkan null jika tidak ada parent
      kdupt: '',
      nmupt: '',
      kdlevel: '',
      type: '1',
      akroupt: '',
      alamat: '',
      telepon: '',
      idbank: null,
      idkabkota: null,
      kepala: null,
      koordinator: null,
      bendahara: null,
      status: '',
      createby: ''
    } as Masterupt; // jangan set idrekd di sini!
  }

  parentOptions: { label: string; value: number | null }[] = [];

  jenisTypeOptions = [
    { label: 'Header', value: '1' },
    { label: 'Detail', value: '0' }
  ];

  kdLevelOptions = [
    // Opsi untuk nilai NULL atau kosong di database
    { label: '--- Pilih Level ---', value: null },
    { label: 'Instansi', value: '1' },
    { label: 'SIPKD/OPD', value: '2' },
    { label: 'UPT', value: '3' },
  ];

  statusOptions = [
    { label: 'Aktif', value: '1' },
    { label: 'Tidak Aktif', value: '0' }
  ];

  // Ambil data jenis type dari value jenisTypeOptions
  getJenisTypeLabel(value: string): string {
    const found = this.jenisTypeOptions.find(opt => opt.value === value);
    return found ? found.label : '-';
  }

  getKdLevelLabel(value: string): string {
    const found = this.kdLevelOptions.find(opt => opt.value === value);
    return found ? found.label : '-';
  }

  getStatusLabel(value: string): string {
    const found = this.statusOptions.find(opt => opt.value === value);
    return found ? found.label : '-';
  }

  loadDaftar(): void {
    this.loadingDaftar = true;
    this.masteruptService.getAll().subscribe({
      next: (data) => {
        this.masteruptList = data;
        this.parentOptions = [
          { label: 'Tidak ada induk', value: null },
          ...data.map(item => ({
            label: `${item.nmupt}`,
            value: item.idupt
          }))
        ];
        this.loadingDaftar = false;
      },
      error: (err) => {
        console.error('Gagal memuat daftar', err);
        this.loadingDaftar = false;
      }
    });
  }

  loadMasterPegawai(): void {
    this.masterpegawaiService.getAll().subscribe((data: Masterpegawai[]) => {
      this.masterpegawaiOptions = [
        ...data.map(pegawai => ({
          label: pegawai.nama,
          value: pegawai.idpegawai
        }))
      ];
    });
  }

  loadMasterBank(): void {
    this.masterbankService.getAll().subscribe((data: Masterbank[]) => {
      this.masterbankOptions = [
        ...data.map(bank => ({
          label: bank.namabank,
          value: bank.idbank
        }))
      ];
    });
  }

  loadMasterKabkotum(): void {
    this.masterkabkotumService.getAll().subscribe((data: Masterkabkotum[]) => {
      this.masterkabkotumOptions = [
        ...data.map(kabkotum => ({
          label: kabkotum.nmkabkota,
          value: kabkotum.idkabkota
        }))
      ];
    });
  }

  openNewDaftar(): void {
    this.selectedMasterupt = this.getEmptyMasterupt();
    this.masteruptDialog = true;
    this.masteruptEdit = false;
  }

  editDaftar(item: Masterupt): void {
    this.selectedMasterupt = { ...item };
    this.masteruptDialog = true;
    this.masteruptEdit = true;
  }

  saveDaftar(): void {
    const payload: any = {
      idparent: this.selectedMasterupt.idparent ?? null,
      kdupt: this.selectedMasterupt.kdupt || '',
      nmupt: this.selectedMasterupt.nmupt || '',
      kdlevel: this.selectedMasterupt.kdlevel?.toString() || '0',
      type: this.selectedMasterupt.type?.trim() || '1',
      akroupt: this.selectedMasterupt.akroupt || '',
      alamat: this.selectedMasterupt.alamat || '',
      telepon: this.selectedMasterupt.telepon || '',
      idbank: this.selectedMasterupt.idbank ?? null,
      idkabkota: this.selectedMasterupt.idkabkota ?? null,
      kepala: this.selectedMasterupt.kepala ?? null,
      koordinator: this.selectedMasterupt.koordinator ?? null,
      bendahara: this.selectedMasterupt.bendahara ?? null,
      status: this.selectedMasterupt.status || '1'
    };

    if (this.masteruptEdit) {
      // update
      payload.updateby = 'admin'; // user login seharusnya diambil dari auth
      this.masteruptService.update(this.selectedMasterupt.idupt!, payload).subscribe({
        next: () => {
          this.loadDaftar();
          this.masteruptDialog = false;
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
      this.masteruptService.create(payload).subscribe({
        next: () => {
          this.loadDaftar();
          this.masteruptDialog = false;
          this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'Data berhasil ditambahkan' });
        },
        error: (err) => {
          console.error('Gagal create data', err);
          this.messageService.add({ severity: 'error', summary: 'Gagal', detail: 'Terjadi kesalahan saat menambahkan data' });
        }
      });
    }
  }

  deleteSelectedDaftar(): void {
    if (!this.selectedMasterupts || this.selectedMasterupts.length === 0) {
      this.messageService.add({ severity: 'warn', summary: 'Peringatan', detail: 'Pilih data yang ingin dihapus' });
      return;
    }

    this.confirmationService.confirm({
      message: `Yakin ingin menghapus ${this.selectedMasterupts.length} data ini?`,
      header: 'Konfirmasi Hapus',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        const ids = this.selectedMasterupts.map(u => u.idupt);
        // panggil API delete untuk tiap id
        ids.forEach(id => {
          this.masteruptService.delete(id).subscribe({
            next: () => {
              this.masteruptList = this.masteruptList.filter(u => u.idupt !== id);
            },
            error: () => {
              this.messageService.add({ severity: 'error', summary: 'Gagal', detail: `Gagal hapus data ID ${id}` });
            }
          });
        });

        this.selectedMasterupts = []; // kosongkan selection
        this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'Data terhapus' });
      }
    });
  }

  confirmDeleteDaftar(item: Masterupt): void {
    this.confirmationService.confirm({
      message: `Yakin ingin menghapus daftar entitas <b>${item.nmupt}</b>?`,
      header: 'Konfirmasi Hapus',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        this.masteruptService.delete(item.idupt).subscribe({
          next: () => {
            this.masteruptList = this.masteruptList.filter(p => p.idupt !== item.idupt);
            this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'Daftar entitas telah dihapus' });
          },
          error: () => {
            this.messageService.add({ severity: 'error', summary: 'Gagal', detail: 'Gagal menghapus daftar entitas' });
          }
        });
      }
    });
  }
}
