using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Transpendataandet
{
    public long Idpendataandet { get; set; }

    public long Idpendataan { get; set; }

    public long Idpenetapan { get; set; }

    public int Nourut { get; set; }

    public string? Lokasi { get; set; }

    public string TransId { get; set; } = null!;

    public string Ket1 { get; set; } = null!;

    public int UsahaId { get; set; }

    public decimal Tarifpajak { get; set; }

    public string Status { get; set; } = null!;

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Transpendataan IdpendataanNavigation { get; set; } = null!;

    public virtual Transpenetapan IdpenetapanNavigation { get; set; } = null!;
}
