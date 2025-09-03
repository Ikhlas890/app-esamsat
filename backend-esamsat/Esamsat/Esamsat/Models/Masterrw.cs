using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterrw
{
    public int Idrw { get; set; }

    public long Idkelurahan { get; set; }

    public string? Kdrw { get; set; }

    public string Alamat { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterkelurahan IdkelurahanNavigation { get; set; } = null!;

    public virtual ICollection<Masterktp> Masterktps { get; set; } = new List<Masterktp>();

    public virtual ICollection<Masterrt> Masterrts { get; set; } = new List<Masterrt>();

    public virtual ICollection<Masterwp> Masterwps { get; set; } = new List<Masterwp>();
}
