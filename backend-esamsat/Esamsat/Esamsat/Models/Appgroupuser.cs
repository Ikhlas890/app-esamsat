using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Appgroupuser
{
    public string Kdgroup { get; set; } = null!;

    public string Nmgroup { get; set; } = null!;

    public string? Ket { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createby { get; set; }

    public DateTime? Updatedate { get; set; }

    public string? Updateby { get; set; }

    public virtual ICollection<Appotor> Appotors { get; set; } = new List<Appotor>();
}
