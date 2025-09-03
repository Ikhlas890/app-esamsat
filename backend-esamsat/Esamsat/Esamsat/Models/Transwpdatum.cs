using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Transwpdatum
{
    public long Idtwpdata { get; set; }

    public long Idnpwpd { get; set; }

    public string? Kdflow { get; set; }

    public DateTime Tgldaftar { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masternpwpd IdnpwpdNavigation { get; set; } = null!;

    public virtual Masterflow? KdflowNavigation { get; set; }

    public virtual ICollection<Transwpdataantri> Transwpdataantris { get; set; } = new List<Transwpdataantri>();

    public virtual ICollection<Transwpdatafile> Transwpdatafiles { get; set; } = new List<Transwpdatafile>();
}
