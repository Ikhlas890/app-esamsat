using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterktp
{
    public long Idktp { get; set; }

    public string? Nip { get; set; }

    public string Nik { get; set; } = null!;

    public string Nama { get; set; } = null!;

    public int? Agama { get; set; }

    public string Nohp { get; set; } = null!;

    public string Alamat { get; set; } = null!;

    public DateTime? Tgldaftar { get; set; }

    public long? Idprovinsi { get; set; }

    public long Idkabkokta { get; set; }

    public long Idkecamatan { get; set; }

    public long Idkelurahan { get; set; }

    public int? Idrw { get; set; }

    public int? Idrt { get; set; }

    public string? Kdrt { get; set; }

    public int? Nikah { get; set; }

    public string? Tempatlahir { get; set; }

    public DateTime? Tgllahir { get; set; }

    public DateTime? Tglregistrasi { get; set; }

    public string? Nokk { get; set; }

    public string? Nobpjs { get; set; }

    public string? Goldarah { get; set; }

    public string? Email { get; set; }

    public string? Pendidikan { get; set; }

    public string? Jeniskelamin { get; set; }

    public string? Dusun { get; set; }

    public string? Pekerjaan { get; set; }

    public string? Namaayah { get; set; }

    public string? Namaibu { get; set; }

    public string? Negara { get; set; }

    public string? Statwn { get; set; }

    public string? Statint { get; set; }

    public DateTime? Tglint { get; set; }

    public string? Ket { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterkabkotum IdkabkoktaNavigation { get; set; } = null!;

    public virtual Masterkecamatan IdkecamatanNavigation { get; set; } = null!;

    public virtual Masterkelurahan IdkelurahanNavigation { get; set; } = null!;

    public virtual Masterprovinsi? IdprovinsiNavigation { get; set; }

    public virtual Masterrt? IdrtNavigation { get; set; }

    public virtual Masterrw? IdrwNavigation { get; set; }

    public virtual ICollection<Masterbadan> Masterbadans { get; set; } = new List<Masterbadan>();

    public virtual ICollection<Masternpwpd> Masternpwpds { get; set; } = new List<Masternpwpd>();

    public virtual ICollection<Masterpegawai> Masterpegawais { get; set; } = new List<Masterpegawai>();

    public virtual ICollection<Transwpdataantri> Transwpdataantris { get; set; } = new List<Transwpdataantri>();
}
