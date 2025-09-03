using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Jnskendaraan
{
    public string Jnskendid { get; set; } = null!;

    public string Jnskend { get; set; } = null!;

    public string Katid { get; set; } = null!;

    public string? Jnsjrid { get; set; }

    public int? Golpjr { get; set; }

    public int? Golujr { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Jnsgolongan> Jnsgolongans { get; set; } = new List<Jnsgolongan>();

    public virtual Jnsjr? Jnsjr { get; set; }

    public virtual ICollection<Jnstarif> Jnstarifs { get; set; } = new List<Jnstarif>();

    public virtual ICollection<Mastertarif> Mastertarifs { get; set; } = new List<Mastertarif>();

    public virtual ICollection<Masterwp> Masterwps { get; set; } = new List<Masterwp>();
}
