using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Mapjnspendapatan
{
    public int Idmapjnsd { get; set; }

    public string Nmjnspendapatan { get; set; } = null!;

    public int? Idrekpkb { get; set; }

    public int? Idrekbbnkb { get; set; }

    public int? Idrekopsenpkb { get; set; }

    public int? Idrekopsenbbnkb { get; set; }

    public int? Idrekpnbp { get; set; }

    public string? Keterangan { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterrekd? IdrekbbnkbNavigation { get; set; }

    public virtual Masterrekd? IdrekopsenbbnkbNavigation { get; set; }

    public virtual Masterrekd? IdrekopsenpkbNavigation { get; set; }

    public virtual Masterrekd? IdrekpkbNavigation { get; set; }

    public virtual Masterrekd? IdrekpnbpNavigation { get; set; }
}
