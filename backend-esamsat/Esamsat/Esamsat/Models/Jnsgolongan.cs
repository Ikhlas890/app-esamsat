using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Jnsgolongan
{
    public string Jnsgolid { get; set; } = null!;

    public string Golongan { get; set; } = null!;

    public string? Katid { get; set; }

    public string? Jnskendid { get; set; }

    public string? Viewall { get; set; }

    public string? Status { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Jnskendaraan? Jnskend { get; set; }

    public virtual Jnskatkendaraan? Kat { get; set; }
}
