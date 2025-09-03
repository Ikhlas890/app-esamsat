using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterkabkotaall
{
    public long Idkabkotaall { get; set; }

    public long Idprovinsi { get; set; }

    public string? Kdkabkota { get; set; }

    public string Nmkabkota { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterprovinsi IdprovinsiNavigation { get; set; } = null!;
}
