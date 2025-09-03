using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterflow
{
    public string Kdflow { get; set; } = null!;

    public string Nmflow { get; set; } = null!;

    public string? Pkb { get; set; }

    public string? Bbn1 { get; set; }

    public string? Bbn2 { get; set; }

    public string? Swd { get; set; }

    public string? AtbKend { get; set; }

    public string? FlowJr { get; set; }

    public string? Stnkbaru { get; set; }

    public string? Tnkb { get; set; }

    public string? Sahstnk { get; set; }

    public string? Perpanjangstnk { get; set; }

    public string? Potongan { get; set; }

    public int? Bataslayanan { get; set; }

    public string? Satuan { get; set; }

    public string? Status { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Mastertarif> Mastertarifs { get; set; } = new List<Mastertarif>();

    public virtual ICollection<Transwpdatum> Transwpdata { get; set; } = new List<Transwpdatum>();
}
