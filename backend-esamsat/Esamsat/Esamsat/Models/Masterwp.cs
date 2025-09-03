using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterwp
{
    public long Idwp { get; set; }

    public string Objekbadanno { get; set; } = null!;

    public string Namabadan { get; set; } = null!;

    public string? Idgroupusaha { get; set; }

    public string? Kodepolisi { get; set; }

    public string? Kodelokasi { get; set; }

    public long? Idbadan { get; set; }

    public string? Idklasifikasi { get; set; }

    public string? Idlokasi { get; set; }

    public string? Alamat { get; set; }

    public long? Idkabkokta { get; set; }

    public long? Idkecamatan { get; set; }

    public long? Idkelurahan { get; set; }

    public int? Idrw { get; set; }

    public int? Idrt { get; set; }

    public string? Telepon { get; set; }

    public string? Fax { get; set; }

    public string? Namapemilik { get; set; }

    public long? Idktp { get; set; }

    public string? Pekerjaan { get; set; }

    public DateTime? Tgldaftar { get; set; }

    public DateTime? Tglsah { get; set; }

    public string? Keteblokir { get; set; }

    public DateTime? Tglhapus { get; set; }

    public string? Groupblokir { get; set; }

    public string Insidentil { get; set; } = null!;

    public string Nopollama { get; set; } = null!;

    public string? Lastskp { get; set; }

    public string? Jnskendid { get; set; }

    public int? Idmerk { get; set; }

    public string? Merk { get; set; }

    public string? Tipe { get; set; }

    public int? Tahunbuat { get; set; }

    public string? Kodebbm { get; set; }

    public string? Bbm { get; set; }

    public int? Cylinder { get; set; }

    public string? Norangka { get; set; }

    public string? Nomesin { get; set; }

    public string? Nobpkb { get; set; }

    public string? Kdmilik { get; set; }

    public string? Kdguna { get; set; }

    public int? Kendke { get; set; }

    public string? Warna { get; set; }

    public string Kdplat { get; set; } = null!;

    public string? Nostnkb { get; set; }

    public string? Daftarstnk { get; set; }

    public DateTime? Tglcetakstnk { get; set; }

    public DateTime? Tglstnk { get; set; }

    public DateTime? Sdstnk { get; set; }

    public DateTime? TglSkp { get; set; }

    public DateTime? Awalskp { get; set; }

    public DateTime? Aakhirskp { get; set; }

    public DateTime? Tglmutasi { get; set; }

    public DateTime? Tgljualbeli { get; set; }

    public string? Nodaftar { get; set; }

    public string? Nosah1 { get; set; }

    public DateTime? Tglsah1 { get; set; }

    public string? Nosah2 { get; set; }

    public DateTime? Tglsah2 { get; set; }

    public string? Nosah3 { get; set; }

    public DateTime? Tglsah3 { get; set; }

    public string? Nosah4 { get; set; }

    public DateTime? Tglsah4 { get; set; }

    public DateTime? Laporjual { get; set; }

    public string? Nikpemilik { get; set; }

    public string? Notelppemilik { get; set; }

    public string? Putih { get; set; }

    public string? Status { get; set; }

    public string? Statint { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterbadan? IdbadanNavigation { get; set; }

    public virtual Masterkabkotum? IdkabkoktaNavigation { get; set; }

    public virtual Masterkecamatan? IdkecamatanNavigation { get; set; }

    public virtual Masterkelurahan? IdkelurahanNavigation { get; set; }

    public virtual Masterrt? IdrtNavigation { get; set; }

    public virtual Masterrw? IdrwNavigation { get; set; }

    public virtual Jnskendaraan? Jnskend { get; set; }

    public virtual Jnsguna? KdgunaNavigation { get; set; }

    public virtual Jnsmilik? KdmilikNavigation { get; set; }

    public virtual Jnsplat KdplatNavigation { get; set; } = null!;

    public virtual ICollection<Masterwpdatum> Masterwpdata { get; set; } = new List<Masterwpdatum>();

    public virtual ICollection<Transdatakohir> Transdatakohirs { get; set; } = new List<Transdatakohir>();
}
