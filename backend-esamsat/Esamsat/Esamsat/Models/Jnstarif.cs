using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Jnstarif
{
    public string Kdjnstarif { get; set; } = null!;

    public string Nmjnstarif { get; set; } = null!;

    public long Idupt { get; set; }

    public string? Jnskendid { get; set; }

    public int? Idrekd { get; set; }

    public string? Status { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterrekd? IdrekdNavigation { get; set; }

    public virtual Masterupt IduptNavigation { get; set; } = null!;

    public virtual Jnskendaraan? Jnskend { get; set; }

    public virtual ICollection<Mastertarifnjop> Mastertarifnjops { get; set; } = new List<Mastertarifnjop>();
}
