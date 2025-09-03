using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterrekd
{
    public int Idrekd { get; set; }

    public int? Idparent { get; set; }

    public string? Mtglevel { get; set; }

    public string Kdrek { get; set; } = null!;

    public string? Nmrek { get; set; }

    public string? Kdjnspjk { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Jnstarif> Jnstarifs { get; set; } = new List<Jnstarif>();

    public virtual Jnspajak? KdjnspjkNavigation { get; set; }

    public virtual ICollection<Mapjnspendapatan> MapjnspendapatanIdrekbbnkbNavigations { get; set; } = new List<Mapjnspendapatan>();

    public virtual ICollection<Mapjnspendapatan> MapjnspendapatanIdrekopsenbbnkbNavigations { get; set; } = new List<Mapjnspendapatan>();

    public virtual ICollection<Mapjnspendapatan> MapjnspendapatanIdrekopsenpkbNavigations { get; set; } = new List<Mapjnspendapatan>();

    public virtual ICollection<Mapjnspendapatan> MapjnspendapatanIdrekpkbNavigations { get; set; } = new List<Mapjnspendapatan>();

    public virtual ICollection<Mapjnspendapatan> MapjnspendapatanIdrekpnbpNavigations { get; set; } = new List<Mapjnspendapatan>();

    public virtual ICollection<Mastertarifnjop> Mastertarifnjops { get; set; } = new List<Mastertarifnjop>();

    public virtual Jnsstrurek? MtglevelNavigation { get; set; }

    public virtual ICollection<Transstsdet> Transstsdets { get; set; } = new List<Transstsdet>();
}
