using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterupt
{
    public long Idupt { get; set; }

    public long? Idparent { get; set; }

    public string Kdupt { get; set; } = null!;

    public string Nmupt { get; set; } = null!;

    public string? Kdlevel { get; set; }

    public string Type { get; set; } = null!;

    public string? Akroupt { get; set; }

    public string? Alamat { get; set; }

    public string? Telepon { get; set; }

    public int? Idbank { get; set; }

    public long? Idkabkota { get; set; }

    public long? Kepala { get; set; }

    public long? Koordinator { get; set; }

    public long? Bendahara { get; set; }

    public string? Status { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Appuser> Appusers { get; set; } = new List<Appuser>();

    public virtual Masterpegawai? BendaharaNavigation { get; set; }

    public virtual Masterbank? IdbankNavigation { get; set; }

    public virtual Masterkabkotum? IdkabkotaNavigation { get; set; }

    public virtual ICollection<Jnstarif> Jnstarifs { get; set; } = new List<Jnstarif>();

    public virtual Masterpegawai? KepalaNavigation { get; set; }

    public virtual Masterpegawai? KoordinatorNavigation { get; set; }

    public virtual ICollection<Masterbendahara> Masterbendaharas { get; set; } = new List<Masterbendahara>();

    public virtual ICollection<Masterkaupt> Masterkaupts { get; set; } = new List<Masterkaupt>();

    public virtual ICollection<Masterpegawai> Masterpegawais { get; set; } = new List<Masterpegawai>();

    public virtual ICollection<Transdatakohir> Transdatakohirs { get; set; } = new List<Transdatakohir>();

    public virtual ICollection<Transst> Transsts { get; set; } = new List<Transst>();
}
