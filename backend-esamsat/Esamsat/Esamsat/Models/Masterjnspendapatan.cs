using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterjnspendapatan
{
    public int Idjnsd { get; set; }

    public string Nmjnspendapatan { get; set; } = null!;

    public int? Parentid { get; set; }

    public string? Kdrek { get; set; }

    public int? Jatuhtempo { get; set; }

    public string? Status { get; set; }

    public string? Selfassessment { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Masterwpdatum> Masterwpdata { get; set; } = new List<Masterwpdatum>();
}
