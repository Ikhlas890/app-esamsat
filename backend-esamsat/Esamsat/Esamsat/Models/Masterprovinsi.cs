using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterprovinsi
{
    public long Idprovinsi { get; set; }

    public string Kdprovinsi { get; set; } = null!;

    public string Nmprovinsi { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Masterbadan> Masterbadans { get; set; } = new List<Masterbadan>();

    public virtual ICollection<Masterkabkotum> Masterkabkota { get; set; } = new List<Masterkabkotum>();

    public virtual ICollection<Masterkabkotaall> Masterkabkotaalls { get; set; } = new List<Masterkabkotaall>();

    public virtual ICollection<Masterktp> Masterktps { get; set; } = new List<Masterktp>();
}
