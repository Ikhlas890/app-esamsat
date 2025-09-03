using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterwpdatum
{
    public long Idwpdata { get; set; }

    public int Idjnsd { get; set; }

    public DateTime Tglpendataan { get; set; }

    public long Idwp { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterjnspendapatan IdjnsdNavigation { get; set; } = null!;

    public virtual Masterwp IdwpNavigation { get; set; } = null!;

    public virtual ICollection<Transpendataan> Transpendataans { get; set; } = new List<Transpendataan>();

    public virtual ICollection<Transpenetapan> Transpenetapans { get; set; } = new List<Transpenetapan>();
}
