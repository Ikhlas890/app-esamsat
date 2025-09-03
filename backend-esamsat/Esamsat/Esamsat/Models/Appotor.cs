using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Appotor
{
    public string Kdgroup { get; set; } = null!;

    public string Roleid { get; set; } = null!;

    public DateTime? Createdate { get; set; }

    public string? Createby { get; set; }

    public DateTime? Updatedate { get; set; }

    public string? Updateby { get; set; }

    public virtual Appgroupuser KdgroupNavigation { get; set; } = null!;

    public virtual Approle Role { get; set; } = null!;
}
