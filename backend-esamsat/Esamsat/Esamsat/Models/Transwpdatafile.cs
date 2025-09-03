using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Transwpdatafile
{
    public long Idfile { get; set; }

    public long Idtwpdata { get; set; }

    public string? Namafile { get; set; }

    public string? Direktory { get; set; }

    public string? Extension { get; set; }

    public long? Size { get; set; }

    public string? Url { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Transwpdatum IdtwpdataNavigation { get; set; } = null!;
}
