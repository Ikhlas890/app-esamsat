using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Mastertarif
{
    public long Idtarif { get; set; }

    public string Kdjnspjk { get; set; } = null!;

    public string? Jnskendid { get; set; }

    public string? Satuan { get; set; }

    public decimal? Awal { get; set; }

    public decimal? Akhir { get; set; }

    public string? Keterangan { get; set; }

    public string? Kdflow { get; set; }

    public string? Kdplat { get; set; }

    public string? Statumum { get; set; }

    public decimal? Tarif { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Jnskendaraan? Jnskend { get; set; }

    public virtual Masterflow? KdflowNavigation { get; set; }

    public virtual Jnspajak KdjnspjkNavigation { get; set; } = null!;

    public virtual Jnsplat? KdplatNavigation { get; set; }
}
