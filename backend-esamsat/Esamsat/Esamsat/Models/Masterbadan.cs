using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterbadan
{
    public long Idbadan { get; set; }

    public string? Nib { get; set; }

    public long? Idktp { get; set; }

    public string Namabadan { get; set; } = null!;

    public string Nohp { get; set; } = null!;

    public string Alamat { get; set; } = null!;

    public DateTime? Tgldaftar { get; set; }

    public long? Idprovinsi { get; set; }

    public long? Idkabkokta { get; set; }

    public string? Ket { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterkabkotum? IdkabkoktaNavigation { get; set; }

    public virtual Masterktp? IdktpNavigation { get; set; }

    public virtual Masterprovinsi? IdprovinsiNavigation { get; set; }

    public virtual ICollection<Masternpwpd> Masternpwpds { get; set; } = new List<Masternpwpd>();

    public virtual ICollection<Masterwp> Masterwps { get; set; } = new List<Masterwp>();
}
