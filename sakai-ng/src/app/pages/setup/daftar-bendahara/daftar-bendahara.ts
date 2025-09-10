import { Component, OnInit } from '@angular/core';
import { Masterbendahara, MasterbendaharaService } from '@/services/masterbendahara.service';
import { Masterpegawai, MasterpegawaiService } from '@/services/masterpegawai.service';
import { Masterbank, MasterbankService } from '@/services/masterbank.service';
import { Masterupt, MasteruptService } from '@/services/masterupt.service';
import { Masterreknrc, MasterreknrcService } from '@/services/masterreknrc.service';
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
  selector: 'app-daftar-bendahara',
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
  templateUrl: './daftar-bendahara.html',
  styleUrl: './daftar-bendahara.scss'
})
export class DaftarBendahara implements OnInit {
  // Daftar bendahara (masterbendahara)
  masterbendaharaList: Masterbendahara[] = [];
  selectedMasterbendahara: Masterbendahara = this.getEmptyMasterbendahara();
  masterbendaharaDialog = false;
  masterbendaharaEdit = false;

  masterpegawaiOptions: { label: string; value: number | null }[] = [];
  masterpegawaiList: Masterpegawai[] = []; // menyimpan semua data pegawai

  masterbankOptions: { label: string; value: number | null }[] = [];

  filteredReknrc: { label: string; value: number }[] = [];

  masteruptOptions: { label: string; value: number | null }[] = [];


  loadingDaftar = false;

  constructor(
    private masterbendaharaService: MasterbendaharaService,
    private masterpegawaiService: MasterpegawaiService,
    private masterreknrcService: MasterreknrcService,
    private masterbankService: MasterbankService,
    private masteruptService: MasteruptService,
    private messageService: MessageService,
    private confirmationService: ConfirmationService
  ) { }

  ngOnInit(): void {
    this.loadDaftar();
    this.loadMasterPegawai();
    this.loadMasterBank();
    this.loadMasterUpt();
  }

  // ==== Daftar Entitas CRUD ====
  getEmptyMasterbendahara(): Masterbendahara {
    return {
      idpegawai: null,
      idupt: null,
      idbank: 0,
      norek: '',
      namarek: '',
      jnsbend: '1',
      status: '1',
      jabatan: '',
      pangkat: '',
      uid: '',
      koordinator: null,
      idreknrc: null,
      telepon: '',
      ket: '',
      createby: ''
    } as Masterbendahara;;
  }

  jenisBendaharaOptions = [
    { label: 'Bendahara Penerimaan', value: '1' }
  ];

  statusOptions = [
    { label: 'Aktif', value: '1' },
    { label: 'Tidak Aktif', value: '0' }
  ];

  // Ambil data jenis jabatan dari value jenisJabatanOptions
  getJenisBendaharaLabel(value: string): string {
    const found = this.jenisBendaharaOptions.find(opt => opt.value === value);
    return found ? found.label : '-';
  }

  getKoordinatorLabel(value: number): string {
    const found = this.masteruptOptions.find(opt => opt.value === value);
    return found ? found.label : '-';
  }

  getStatusLabel(value: string): string {
    const found = this.statusOptions.find(opt => opt.value === value);
    return found ? found.label : '-';
  }

  loadDaftar(): void {
    this.loadingDaftar = true;
    this.masterbendaharaService.getAll().subscribe({
      next: (data) => {
        this.masterbendaharaList = data;
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
      this.masterpegawaiList = data;

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

  loadMasterUpt(): void {
    this.masteruptService.getAll().subscribe((data: Masterupt[]) => {
      this.masteruptOptions = [
        ...data.map(upt => ({
          label: upt.nmupt,
          value: upt.idupt
        }))
      ];
    });
  }

  searchReknrc(event: any) {
    const query = event.query;
    this.masterreknrcService.getForSelect(query).subscribe(data => {
      this.filteredReknrc = data.map(r => ({
        label: `${r.kdrek} - ${r.nmrek}`,
        value: r.idreknrc
      }));
    });
  }

  onPegawaiChange(event: any) {
    const selectedId = event.value; // idpegawai yang dipilih
    const pegawai = this.masterpegawaiList.find(p => p.idpegawai === selectedId);

    if (pegawai) {
      this.selectedMasterbendahara.jabatan = pegawai.jabatan;
      this.selectedMasterbendahara.pangkat = pegawai.pangkat;
    } else {
      this.selectedMasterbendahara.jabatan = undefined;
      this.selectedMasterbendahara.pangkat = undefined;
    }
  }

  openNewDaftar(): void {
    this.selectedMasterbendahara = this.getEmptyMasterbendahara();
    this.masterbendaharaDialog = true;
    this.masterbendaharaEdit = false;
  }

  editDaftar(item: Masterbendahara): void {
    this.selectedMasterbendahara = { ...item };
    this.masterbendaharaDialog = true;
    this.masterbendaharaEdit = true;
  }

  saveDaftar(): void {
    const payload: any = {
      idpegawai: this.selectedMasterbendahara.idpegawai ?? null,
      idbank: this.selectedMasterbendahara.idbank ?? null,
      norek: this.selectedMasterbendahara.norek || '',
      namarek: this.selectedMasterbendahara.namarek || '',
      jnsbend: this.selectedMasterbendahara.jnsbend?.trim() || '1',
      status: this.selectedMasterbendahara.status || '1',
      jabatan: this.selectedMasterbendahara.jabatan || '',
      pangkat: this.selectedMasterbendahara.pangkat || '',
      uid: this.selectedMasterbendahara.uid || '',
      koordinator: this.selectedMasterbendahara.koordinator ?? null,
      idreknrc: this.selectedMasterbendahara.idreknrc ?? null,
      telepon: this.selectedMasterbendahara.telepon || '',
      ket: this.selectedMasterbendahara.ket || ''
    };


    console.log('daftar payload', payload);

    if (this.masterbendaharaEdit) {
      // update
      payload.updateby = 'admin'; // user login seharusnya diambil dari auth
      this.masterbendaharaService.update(this.selectedMasterbendahara.idbend!, payload).subscribe({
        next: () => {
          this.loadDaftar();
          this.masterbendaharaDialog = false;
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
      // pastikan idbend tidak dikirim sama sekali saat create
      this.masterbendaharaService.create(payload).subscribe({
        next: () => {
          this.loadDaftar();
          this.masterbendaharaDialog = false;
          this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'Data berhasil ditambahkan' });
        },
        error: (err) => {
          console.error('Gagal create data', err);
          this.messageService.add({ severity: 'error', summary: 'Gagal', detail: 'Terjadi kesalahan saat menambahkan data' });
        }
      });
    }
  }


  confirmDeleteDaftar(item: Masterbendahara): void {
    this.confirmationService.confirm({
      message: `Yakin ingin menghapus daftar bendahara <b>${item.namarek}</b>?`,
      header: 'Konfirmasi Hapus',
      icon: 'pi pi-exclamation-triangle',
      accept: () => {
        this.masterbendaharaService.delete(item.idbend!).subscribe({
          next: () => {
            this.masterbendaharaList = this.masterbendaharaList.filter(p => p.idbend !== item.idbend);
            this.messageService.add({ severity: 'success', summary: 'Berhasil', detail: 'Daftar bendahara telah dihapus' });
          },
          error: () => {
            this.messageService.add({ severity: 'error', summary: 'Gagal', detail: 'Gagal menghapus daftar bendahara' });
          }
        });
      }
    });
  }
}
