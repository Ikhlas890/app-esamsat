using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Transstsdet
{
    public long Idstsdet { get; set; }

    public long Idsts { get; set; }

    public int Idrekd { get; set; }

    public decimal Nilaists { get; set; }

    public string Jenis { get; set; } = null!;

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterrekd IdrekdNavigation { get; set; } = null!;

    public virtual Transst IdstsNavigation { get; set; } = null!;
}
