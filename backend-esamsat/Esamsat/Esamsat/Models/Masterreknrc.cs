using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterreknrc
{
    public int Idreknrc { get; set; }

    public string? Mtglevel { get; set; }

    public string Kdrek { get; set; } = null!;

    public string? Nmrek { get; set; }

    public string? Type { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Masterbendahara> Masterbendaharas { get; set; } = new List<Masterbendahara>();

    public virtual Jnsstrurek? MtglevelNavigation { get; set; }
}
