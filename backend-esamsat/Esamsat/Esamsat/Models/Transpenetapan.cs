using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Transpenetapan
{
    public long Idpenetapan { get; set; }

    public long Idkohir { get; set; }

    public string? Nokohir { get; set; }

    public long Idwpdata { get; set; }

    public DateTime Tglpenetapan { get; set; }

    public DateTime Tgljatuhtempo { get; set; }

    public DateTime Masaawal { get; set; }

    public DateTime Masaakhir { get; set; }

    public int Uruttgl { get; set; }

    public decimal? Jmlomzetawal { get; set; }

    public decimal Tarifpajak { get; set; }

    public decimal? Denda { get; set; }

    public decimal? Kenaikan { get; set; }

    public string Statbayar { get; set; } = null!;

    public DateTime? Tglbayar { get; set; }

    public decimal? Jmlbayar { get; set; }

    public DateTime? Tglkurangbayar { get; set; }

    public decimal? Jmlkurangbayar { get; set; }

    public byte? Jmlperingatan { get; set; }

    public string? Kdflow { get; set; }

    public string Status { get; set; } = null!;

    public string? OpsId { get; set; }

    public decimal? OpsProv { get; set; }

    public decimal? OpsKota { get; set; }

    public decimal? DendaOpsProv { get; set; }

    public decimal? DendaOpsKota { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Transdatakohir IdkohirNavigation { get; set; } = null!;

    public virtual Masterwpdatum IdwpdataNavigation { get; set; } = null!;

    public virtual ICollection<Transpendataandet> Transpendataandets { get; set; } = new List<Transpendataandet>();
}
