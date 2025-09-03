using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Jnsstrurek
{
    public string Mtglevel { get; set; } = null!;

    public string Nmlevel { get; set; } = null!;

    public string Kterangan { get; set; } = null!;

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Masterrekd> Masterrekds { get; set; } = new List<Masterrekd>();

    public virtual ICollection<Masterreknrc> Masterreknrcs { get; set; } = new List<Masterreknrc>();
}
