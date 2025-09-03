using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Jnsdok
{
    public string Kddok { get; set; } = null!;

    public string Namadok { get; set; } = null!;

    public string? Kterangan { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Masterjabttd> Masterjabttds { get; set; } = new List<Masterjabttd>();
}
