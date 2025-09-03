using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masternpwpd
{
    public long Idnpwpd { get; set; }

    public string? Statnpwpd { get; set; }

    public string Npwpd { get; set; } = null!;

    public long? Idbadan { get; set; }

    public long? Idktp { get; set; }

    public DateTime? Tgldaftar { get; set; }

    public string? Nib { get; set; }

    public string? Namabadan { get; set; }

    public string? Alamat { get; set; }

    public string? Status { get; set; }

    public string? Ket { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterbadan? IdbadanNavigation { get; set; }

    public virtual Masterktp? IdktpNavigation { get; set; }

    public virtual ICollection<Transwpdatum> Transwpdata { get; set; } = new List<Transwpdatum>();
}
