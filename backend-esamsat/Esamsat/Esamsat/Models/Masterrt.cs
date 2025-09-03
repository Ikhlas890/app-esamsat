using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterrt
{
    public int Idrt { get; set; }

    public int Idrw { get; set; }

    public string? Kdrt { get; set; }

    public string Status { get; set; } = null!;

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterrw IdrwNavigation { get; set; } = null!;

    public virtual ICollection<Masterktp> Masterktps { get; set; } = new List<Masterktp>();

    public virtual ICollection<Masterwp> Masterwps { get; set; } = new List<Masterwp>();
}
