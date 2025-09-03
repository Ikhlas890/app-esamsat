using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masteruunjop
{
    public long Iduunjop { get; set; }

    public string? Noperkada { get; set; }

    public string? Isiperkada { get; set; }

    public string? Tahun { get; set; }

    public string? Status { get; set; }

    public string? Ket { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Mastertarifnjop> Mastertarifnjops { get; set; } = new List<Mastertarifnjop>();
}
