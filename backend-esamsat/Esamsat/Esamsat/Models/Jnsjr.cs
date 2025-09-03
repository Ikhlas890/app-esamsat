using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Jnsjr
{
    public string Jnsjrid { get; set; } = null!;

    public string Kodejr { get; set; } = null!;

    public string Goljns { get; set; } = null!;

    public string Pu { get; set; } = null!;

    public byte Roda { get; set; }

    public string? Kterangan { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Jnskendaraan> Jnskendaraans { get; set; } = new List<Jnskendaraan>();
}
