using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterkabkotum
{
    public long Idkabkota { get; set; }

    public long Idprovinsi { get; set; }

    public string? Kdkabkota { get; set; }

    public string Nmkabkota { get; set; } = null!;

    public string Akronim { get; set; } = null!;

    public string Ibukota { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Bpkbid { get; set; } = null!;

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterprovinsi IdprovinsiNavigation { get; set; } = null!;

    public virtual ICollection<Masterbadan> Masterbadans { get; set; } = new List<Masterbadan>();

    public virtual ICollection<Masterkecamatan> Masterkecamatans { get; set; } = new List<Masterkecamatan>();

    public virtual ICollection<Masterktp> Masterktps { get; set; } = new List<Masterktp>();

    public virtual ICollection<Masterlibur> Masterliburs { get; set; } = new List<Masterlibur>();

    public virtual ICollection<Masterupt> Masterupts { get; set; } = new List<Masterupt>();

    public virtual ICollection<Masterwp> Masterwps { get; set; } = new List<Masterwp>();
}
