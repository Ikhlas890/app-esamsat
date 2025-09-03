using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Jnsmilik
{
    public string Kdmilik { get; set; } = null!;

    public string Milik { get; set; } = null!;

    public string Bpkpid { get; set; } = null!;

    public string? Status { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Masterwp> Masterwps { get; set; } = new List<Masterwp>();
}
