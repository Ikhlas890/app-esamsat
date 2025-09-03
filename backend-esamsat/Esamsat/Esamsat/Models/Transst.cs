using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Transst
{
    public long Idsts { get; set; }

    public long Idupt { get; set; }

    public string? SetoranDari { get; set; }

    public long Idbend { get; set; }

    public string Nosts { get; set; } = null!;

    public DateTime Tglsts { get; set; }

    public string Keterangan { get; set; } = null!;

    public string Statbayar { get; set; } = null!;

    public string? Ntpd { get; set; }

    public DateTime? Tglntpd { get; set; }

    public byte? Statsts { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterbendahara IdbendNavigation { get; set; } = null!;

    public virtual Masterupt IduptNavigation { get; set; } = null!;

    public virtual ICollection<Transstsdet> Transstsdets { get; set; } = new List<Transstsdet>();
}
