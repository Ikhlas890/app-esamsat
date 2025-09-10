import { Component, OnInit, ViewChild } from '@angular/core';
import { Masterrekd, MasterrekdService } from '@/services/masterrekd.service';
import { Masterreknrc, MasterreknrcService } from '@/services/masterreknrc.service';
import { Masterjnsstrurek, MasterjnsstrurekService } from '@/services/jnsstrurek.service';
import { Jnspajak, JnspajakService } from '@/services/jnspajak.service';
import { MessageService, ConfirmationService } from 'primeng/api';
import { TabsModule } from 'primeng/tabs';
import { TableModule, Table } from 'primeng/table';
import { ButtonModule } from 'primeng/button';
import { DialogModule } from 'primeng/dialog';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { InputTextModule } from 'primeng/inputtext';
import { IconFieldModule } from 'primeng/iconfield';
import { InputIconModule } from 'primeng/inputicon';
import { ToastModule } from 'primeng/toast';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { SelectButtonModule } from 'primeng/selectbutton';
import { SelectItem, SelectModule } from 'primeng/select';
import { RadioButtonModule } from 'primeng/radiobutton';
import * as XLSX from 'xlsx';
import * as FileSaver from 'file-saver';
import { ToolbarModule } from 'primeng/toolbar';

@Component({
  selector: 'app-kode-rekening',
  imports: [
    CommonModule,
    FormsModule,
    TabsModule,
    TableModule,
    ButtonModule,
    DialogModule,
    InputTextModule,
    IconFieldModule,
    InputIconModule,
    DialogModule,
    ToastModule,
    ConfirmDialogModule,
    SelectModule,
    RadioButtonModule,
    ToolbarModule
  ],
  providers: [MessageService, ConfirmationService],
  templateUrl: './kode-rekening.html',
  styleUrl: './kode-rekening.scss'
})
export class KodeRekening implements OnInit {
  // Tab Management
  activeTab = 0;

  // Pendapatan (masterrekd)
  masterrekdList: Masterrekd[] = [];
  masterrekdDialog = false;
  masterrekdEdit = false;

  // Untuk multi-select di tabel
  selectedMasterrekds: Masterrekd[] = [];

  // untuk satu record aktif (object tunggal, di form/dialog).
  selectedMasterrekd: Masterrekd = this.getEmptyMasterrekd();

  // Neraca (masterreknrc)
  masterreknrcList: Masterreknrc[] = [];
  masterreknrcDialog = false;
  masterreknrcEdit = false;

  // Untuk multi-select di tabel
  selectedMasterreknrcs: Masterreknrc[] = [];

  // untuk satu record aktif (object tunggal, di form/dialog).
  selectedMasterreknrc: Masterreknrc = this.getEmptyMasterreknrc();

  loadingPendapatan = false;
  loadingNeraca = false;

  constructor(
    private masterrekdService: MasterrekdService,
    private masterreknrcService: MasterreknrcService,
    private masterjnsstrurekService: MasterjnsstrurekService,
    private jnspajakService: JnspajakService,
    private messageService: MessageService,
    private confirmationService: ConfirmationService
  ) { }

  // Export data (Excel)
  @ViewChild('dt') dt!: Table;
  @ViewChild('neracadt') neracadt!: Table;

  onGlobalFilter(table: Table, event: Event) {
    table.filterGlobal((event.target as HTMLInputElement).value, 'contains');
  }

  // Export Pendapatan
  exportExcelPendapatan() {
    const dataToExport = this.dt?.filteredValue || this.masterrekdList;

    const worksheet = XLSX.utils.json_to_sheet(dataToExport);
    const workbook = { Sheets: { data: worksheet }, SheetNames: ['data'] };

    const excelBuffer: any = XLSX.write(workbook, { bookType: 'xlsx', type: 'array' });
    this.saveAsExcelFilePendapatan(excelBuffer, 'pendapatan');
  }

  private saveAsExcelFilePendapatan(buffer: any, fileName: string): void {
    const data: Blob = new Blob([buffer], { type: 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;charset=UTF-8' });
    FileSaver.saveAs(data, `${fileName}.xlsx`);
  }

  // Export Neraca
  exportExcelNeraca() {
    const dataToExport = this.neracadt?.filteredValue || this.masterreknrcList;

    const worksheet = XLSX.utils.json_to_sheet(dataToExport);
    const workbook = { Sheets: { data: worksheet }, SheetNames: ['data'] };

    const excelBuffer: any = XLSX.write(workbook, { bookType: 'xlsx', type: 'array' });
    this.saveAsExcelFileNeraca(excelBuffer, 'neraca');
  }

  private saveAsExcelFileNeraca(buffer: any, fileName: string): void {
    const data: Blob = new Blob([buffer], { type: 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;charset=UTF-8' });
    FileSaver.saveAs(data, `${fileName}.xlsx`);
  }
  // End export data (Excel)

  ngOnInit(): void {
    this.loadPendapatan();
    this.loadNeraca();
    this.loadMasterJnsstrurek();
    this.loadJnspajak();
  }

  // ==== Pendapatan CRUD ====
  getEmptyMasterrekd(): Masterrekd {
    return {
      idparent: null, // biarkan null jika tidak ada parent
      mtglevel: '',
      kdrek: '',
      nmrek: '',
      kdjnspjk: '',
      type: '',
      status: '',
      createby: ''
    } as Masterrekd; // jangan set idrekd di sini!
  }


  masterjnsstrurekOptions: { label: string; value: string | null }[] = [];
  jnspajakOptions: { label: string; value: string | null }[] = [];

  parentOptions: { label: string; value: number | null }[] = [];

  statusOptions = [
    { label: 'Aktif', value: '1' },
    { label: 'Tidak Aktif', value: '0' }
  ];

  filterByJenisPajak(selectedJenis: string | null) {
    if (selectedJenis) {
      this.dt.filter(selectedJenis, 'kdjnspjk', 'equals');
    } else {
      this.dt.filter('', 'kdjnspjk', 'equals'); // Reset filter jenis pajak
    }
  }

  getJenisPajakLabel(value: string): string {
    const found = this.jnspajakOptions.find(opt => opt.value === value);
    return found ? found.label : '-';
  }

  // 1. Load dropdown Level
  loadMasterJnsstrurek(): void {
    this.masterjnsstrurekService.getAll().subscribe((data: Masterjnsstrurek[]) => {
      this.masterjnsstrurekOptions = data.map(jnsstrurek => ({
        label: jnsstrurek.nmlevel,
        value: jnsstrurek.mtglevel!
      }));

      // 2. Setelah options siap, set mtglevel dari selectedMasterrekd
      if (this.selectedMasterrekd && this.selectedMasterrekd.mtglevel) {
        this.selectedMasterrekd.mtglevel = this.selectedMasterrekd.mtglevel;
      }
    });
  }

  getStatusLabel(value: string): string {
    const found = this.statusOptions.find(opt => opt.value === value);
    return found ? found.label : '-';
  }

  loadPendapatan(): void {
    this.loadingPendapatan = true;
    this.masterrekdService.getAll().subscribe({
      next: (data) => {
        this.masterrekdList = data;
        this.parentOptions = [
          { label: 'Tidak ada induk', value: null },
          ...data.map(item => ({
            label: `${item.nmrek}`,
            value: item.idrekd
          }))
        ];
        this.loadingPendapatan = false;
      },
      error: (err) => {
        console.error('Gagal memuat pendapatan', err);
        this.loadingPendapatan = false;
      }
    });
  }

  loadJnspajak(): void {
    this.jnspajakService.getAll().subscribe((data: Jnspajak[]) => {
      this.jnspajakOptions = [
        { label: 'Pilih semua', value: null },
        ...data.map(jns => ({
          label: jns.nmjnspjk,
          value: jns.kdjnspjk
        }))
      ];
    });
  }

  openNewPendapatan(): void {
    this.selectedMasterrekd = this.getEmptyMasterrekd();
    this.masterrekdDialog = true;
    this.masterrekdEdit = false;
  }

  editPendapatan(item: Masterrekd): void {
    this.selectedMasterrekd = { ...item };
    this.masterrekdDialog = true;
    this.masterrekdEdit = true;
  }

  savePendapatan(): void {
    const payload = {
      idrekd: this.masterrekdEdit ? this.selectedMasterrekd.idrekd ?? 0 : 0,
      idparent: this.selectedMasterrekd.idparent ?? null,
      mtglevel: this.selectedMasterrekd.mtglevel || '',
      kdrek: this.selectedMasterrekd.kdrek || '',
      nmrek: this.selectedMasterrekd.nmrek || '',
      kdjnspjk: this.selectedMasterrekd.kdjnspjk || '',
      type: this.selectedMasterrekd.type || 'D',
      status: this.selectedMasterrekd.status || '1',
      createby: 'admin'
    };

    if (this.masterrekdEdit) {
      this.masterrekdService.update(payload.idrekd, payload).subscribe({
        next: () => {
          this.loadPendapatan();
          this.masterrekdDialog = false;
          this.messageService.add({
            severity: 'success',
            summary: 'Berhasil',
            detail: 'Data pendapatan berhasil diperbarui'
          });
        },
        error: (err) => {
          console.error('Gagal update pendapatan', err);
          this.messageService.add({
            severity: 'error',
            summary: 'Gagal',
            detail: 'Terjadi kesalahan saat memperbarui data'
          });
        }
      });
    } else {
      this.masterrekdService.create(payload).subscribe({
        next: () => {
          this.loadPendapatan();
          this.masterrekdDialog = false;
          this.messageService.add({
            severity: 'success',
            summary: 'Berhasil',
            detail: 'Data pendapatan berhasil ditambahkan'
          });
        },
        error: (err) => {
          console.error('Gagal create pendapatan', err);
          this.messageService.add({
            severity: 'error',
            summary: 'Gagal',
            detail: 'Terjadi kesalahan saat menambahkan data'
          });
        }
      });
    }
  }

  deleteSelectedPendapatan(): void {
    if (!this.selectedMasterrekds || this.selectedMasterrekds.length === 0) {
      this.messageService.add({ severity: 'warn', summary: 'Peringatan', detail: 'Pilih data yang ingin dihapus' });
      return;
    }

    this.confirmationService.confirm({
      message: `Yakin ingin menghapus ${this.selectedMasterrekds.length} data ini?`,
      header: 'Konfirmasi Hapus',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        const ids = this.selectedMasterrekds.map(u => u.idrekd);
        // panggil API delete untuk tiap id
        ids.forEach(id => {
          this.masterrekdService.delete(id).subscribe({
            next: () => {
              this.masterrekdList = this.masterrekdList.filter(u => u.idrekd !== id);
            },
            error: () => {
              this.messageService.add({ severity: 'error', summary: 'Gagal', detail: `Gagal hapus data ID ${id}` });
            }
          });
        });

        this.selectedMasterrekds = []; // kosongkan selection
        this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'Data terhapus' });
      }
    });
  }

  confirmDeletePendapatan(item: Masterrekd): void {
    this.confirmationService.confirm({
      message: `Yakin ingin menghapus pendapatan <b>${item.nmrek}</b>?`,
      header: 'Konfirmasi Hapus',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        this.masterrekdService.delete(item.idrekd).subscribe({
          next: () => {
            this.masterrekdList = this.masterrekdList.filter(p => p.idrekd !== item.idrekd);
            this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'Pendapatan telah dihapus' });
          },
          error: () => {
            this.messageService.add({ severity: 'error', summary: 'Gagal', detail: 'Gagal menghapus pendapatan' });
          }
        });
      }
    });
  }

  // ==== Neraca CRUD ====
  getEmptyMasterreknrc(): Masterreknrc {
    return {
      idreknrc: 0,
      kdrek: '',
      nmrek: '',
      type: ''
    };
  }

  loadNeraca(): void {
    this.loadingNeraca = true;
    this.masterreknrcService.getAll().subscribe({
      next: (data) => {
        this.masterreknrcList = data;
        this.loadingNeraca = false;
      },
      error: (err) => {
        console.error('Gagal memuat neraca', err);
        this.loadingNeraca = false;
      }
    });
  }

  openNewNeraca(): void {
    this.selectedMasterreknrc = this.getEmptyMasterreknrc();
    this.masterreknrcDialog = true;
    this.masterreknrcEdit = false;
  }

  editNeraca(item: Masterreknrc): void {
    this.selectedMasterreknrc = { ...item };
    this.masterreknrcDialog = true;
    this.masterreknrcEdit = true;
  }

  saveNeraca(): void {
  const payload = {
    idreknrc: this.masterreknrcEdit ? this.selectedMasterreknrc.idreknrc ?? 0 : 0,
    kdrek: this.selectedMasterreknrc.kdrek || '',
    nmrek: this.selectedMasterreknrc.nmrek || '',
    type: this.selectedMasterreknrc.type || 'H',
    createby: 'admin'
  };

  if (this.masterreknrcEdit) {
    this.masterreknrcService.update(payload.idreknrc, payload).subscribe({
      next: () => {
        this.loadNeraca();
        this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'Data neraca berhasil diperbarui' });
        this.masterreknrcDialog = false;
      },
      error: (err) => {
        console.error('Gagal update neraca', err);
        this.messageService.add({ severity: 'error', summary: 'Gagal', detail: 'Terjadi kesalahan saat memperbarui data' });
      }
    });
  } else {
    this.masterreknrcService.create(payload).subscribe({
      next: () => {
        this.loadNeraca();
        this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'Data neraca berhasil ditambahkan' });
        this.masterreknrcDialog = false;
      },
      error: (err) => {
        console.error('Gagal create neraca', err);
        this.messageService.add({ severity: 'error', summary: 'Gagal', detail: 'Terjadi kesalahan saat menambahkan data' });
      }
    });
  }
}

  deleteSelectedNeraca(): void {
    if (!this.selectedMasterreknrcs || this.selectedMasterreknrcs.length === 0) {
      this.messageService.add({ severity: 'warn', summary: 'Peringatan', detail: 'Pilih data yang ingin dihapus' });
      return;
    }

    this.confirmationService.confirm({
      message: `Yakin ingin menghapus ${this.selectedMasterreknrcs.length} data ini?`,
      header: 'Konfirmasi Hapus',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        const ids = this.selectedMasterreknrcs.map(u => u.idreknrc);
        // panggil API delete untuk tiap id
        ids.forEach(id => {
          this.masterreknrcService.delete(id).subscribe({
            next: () => {
              this.masterreknrcList = this.masterreknrcList.filter(u => u.idreknrc !== id);
            },
            error: () => {
              this.messageService.add({ severity: 'error', summary: 'Gagal', detail: `Gagal hapus data ID ${id}` });
            }
          });
        });

        this.selectedMasterreknrcs = []; // kosongkan selection
        this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'Data terhapus' });
      }
    });
  }

  confirmDeleteNeraca(item: Masterreknrc): void {
    this.confirmationService.confirm({
      message: `Yakin ingin menghapus neraca <b>${item.nmrek}</b>?`,
      header: 'Konfirmasi Hapus',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        this.masterreknrcService.delete(item.idreknrc).subscribe({
          next: () => {
            this.masterreknrcList = this.masterreknrcList.filter(p => p.idreknrc !== item.idreknrc);
            this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'Neraca telah dihapus' });
          },
          error: () => {
            this.messageService.add({ severity: 'error', summary: 'Gagal', detail: 'Gagal menghapus neraca' });
          }
        });
      }
    });
  }

  // Tab change
  onTabChange(index: number): void {
    this.activeTab = index;
  }
}
