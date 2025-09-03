using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Jnskatkendaraan
{
    public string Katid { get; set; } = null!;

    public string Kendaraan { get; set; } = null!;

    public string Jenisbpkb { get; set; } = null!;

    public string? Status { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Jnsgolongan> Jnsgolongans { get; set; } = new List<Jnsgolongan>();
}
