using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Jnsplat
{
    public string Kdplat { get; set; } = null!;

    public string Plat { get; set; } = null!;

    public string Pu { get; set; } = null!;

    public byte PlatJr { get; set; }

    public decimal NumPkb { get; set; }

    public decimal NumBbn1 { get; set; }

    public decimal NumBbn2 { get; set; }

    public decimal UmOrg { get; set; }

    public decimal UmBrg { get; set; }

    public decimal DnumPkb { get; set; }

    public decimal DnumBbn { get; set; }

    public decimal DumOrg { get; set; }

    public decimal DumBrg { get; set; }

    public decimal AbPkb { get; set; }

    public decimal AbBbn1 { get; set; }

    public decimal AbBbn2 { get; set; }

    public decimal NumFiskal { get; set; }

    public string Snid { get; set; } = null!;

    public decimal OpsPkb { get; set; }

    public decimal OpsBbn { get; set; }

    public decimal OpsNumPkb { get; set; }

    public decimal OpsNumBbn1 { get; set; }

    public decimal OpsNumBbn2 { get; set; }

    public decimal OpsDnumPkb { get; set; }

    public decimal OpsDnumBbn { get; set; }

    public decimal MinNumPkb { get; set; }

    public decimal MinNumBbn1 { get; set; }

    public decimal MinNumBbn2 { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Mastertarif> Mastertarifs { get; set; } = new List<Mastertarif>();

    public virtual ICollection<Masterwp> Masterwps { get; set; } = new List<Masterwp>();
}
