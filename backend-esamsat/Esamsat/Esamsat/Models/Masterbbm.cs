using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterbbm
{
    public string Kodebbm { get; set; } = null!;

    public string Namabbm { get; set; } = null!;

    public string? Ket { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Mastertarifnjop> Mastertarifnjops { get; set; } = new List<Mastertarifnjop>();
}
