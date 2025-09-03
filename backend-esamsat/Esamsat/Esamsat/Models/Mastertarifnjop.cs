using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Mastertarifnjop
{
    public long Idtarifnjop { get; set; }

    public long Iduunjop { get; set; }

    public int? Idrekd { get; set; }

    public string? Kdjnstarif { get; set; }

    public string? Namatarif { get; set; }

    public int? Idmerk { get; set; }

    public string? Tipe { get; set; }

    public string? Silinder { get; set; }

    public string? Tahun { get; set; }

    public string? Kodebbm { get; set; }

    public decimal? Njop { get; set; }

    public string? Status { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Mastermerk? IdmerkNavigation { get; set; }

    public virtual Masterrekd? IdrekdNavigation { get; set; }

    public virtual Masteruunjop IduunjopNavigation { get; set; } = null!;

    public virtual Jnstarif? KdjnstarifNavigation { get; set; }

    public virtual Masterbbm? KodebbmNavigation { get; set; }
}
