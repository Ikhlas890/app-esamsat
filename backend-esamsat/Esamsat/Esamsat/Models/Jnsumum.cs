using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Jnsumum
{
    public string Kdumum { get; set; } = null!;

    public string Nmumum { get; set; } = null!;

    public string Keterangan { get; set; } = null!;

    public string? Status { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }
}
