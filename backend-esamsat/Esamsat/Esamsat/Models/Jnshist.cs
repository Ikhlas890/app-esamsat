using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Jnshist
{
    public string Kdhist { get; set; } = null!;

    public string Nmhist { get; set; } = null!;

    public string? Kdflow { get; set; }

    public string? Status { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }
}
