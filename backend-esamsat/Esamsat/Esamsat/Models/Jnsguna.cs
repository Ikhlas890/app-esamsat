using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Jnsguna
{
    public string Kdguna { get; set; } = null!;

    public string Guna { get; set; } = null!;

    public string? Gunaplat { get; set; }

    public decimal? Progresif { get; set; }

    public string Groupbpkb { get; set; } = null!;

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Masterwp> Masterwps { get; set; } = new List<Masterwp>();
}
