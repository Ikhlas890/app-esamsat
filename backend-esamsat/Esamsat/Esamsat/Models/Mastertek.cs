using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Mastertek
{
    public int Idteks { get; set; }

    public string Datateks { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }
}
