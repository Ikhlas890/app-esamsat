using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Jnspajak
{
    public string Kdjnspjk { get; set; } = null!;

    public string Nmjnspjk { get; set; } = null!;

    public string? Kterangan { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Masterrekd> Masterrekds { get; set; } = new List<Masterrekd>();

    public virtual ICollection<Mastertarif> Mastertarifs { get; set; } = new List<Mastertarif>();
}
