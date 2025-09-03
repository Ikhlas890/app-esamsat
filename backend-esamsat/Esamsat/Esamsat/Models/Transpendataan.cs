using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Transpendataan
{
    public long Idpendataan { get; set; }

    public string Spt { get; set; } = null!;

    public long Idwpdata { get; set; }

    public DateTime Tglpendataan { get; set; }

    public DateTime Masaawal { get; set; }

    public DateTime Masaakhir { get; set; }

    public int Uruttgl { get; set; }

    public decimal? Jmlomzetawal { get; set; }

    public decimal Tarifpjk { get; set; }

    public long Idupt { get; set; }

    public string? Kdflow { get; set; }

    public string Status { get; set; } = null!;

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterwpdatum IdwpdataNavigation { get; set; } = null!;

    public virtual ICollection<Transpendataandet> Transpendataandets { get; set; } = new List<Transpendataandet>();
}
