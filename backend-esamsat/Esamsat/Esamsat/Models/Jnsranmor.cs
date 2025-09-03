using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Jnsranmor
{
    public string Kdranmor { get; set; } = null!;

    public string Nmranmor { get; set; } = null!;

    public string Snid { get; set; } = null!;

    public string? Status { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }
}
