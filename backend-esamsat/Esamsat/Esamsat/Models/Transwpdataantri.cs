using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Transwpdataantri
{
    public int Idantri { get; set; }

    public long Idtwpdata { get; set; }

    public string Noantri { get; set; } = null!;

    public long? Idktp { get; set; }

    public string? Statantri { get; set; }

    public string? Ket { get; set; }

    public string? Tglantri { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterktp? IdktpNavigation { get; set; }

    public virtual Transwpdatum IdtwpdataNavigation { get; set; } = null!;
}
