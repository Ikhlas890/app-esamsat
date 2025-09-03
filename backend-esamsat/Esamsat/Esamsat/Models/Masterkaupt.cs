using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterkaupt
{
    public long Idkaupt { get; set; }

    public long? Idpegawai { get; set; }

    public long Idupt { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterpegawai? IdpegawaiNavigation { get; set; }

    public virtual Masterupt IduptNavigation { get; set; } = null!;
}
