using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Approle
{
    public string Roleid { get; set; } = null!;

    public long? Idapp { get; set; }

    public string? Role { get; set; }

    public string? Type { get; set; }

    public string? Menuid { get; set; }

    public string? Parentid { get; set; }

    public string? Bantuan { get; set; }

    public string? Link { get; set; }

    public string? Icon { get; set; }

    public int? Kdlevel { get; set; }

    public int? Show { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createby { get; set; }

    public DateTime? Updatedate { get; set; }

    public string? Updateby { get; set; }

    public virtual ICollection<Appotor> Appotors { get; set; } = new List<Appotor>();
}
