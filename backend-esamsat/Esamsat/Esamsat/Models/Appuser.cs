using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Appuser
{
    public string Userid { get; set; } = null!;

    public long? Idupt { get; set; }

    public string Kdtahap { get; set; } = null!;

    public string? Pwd { get; set; }

    public long? Idpeg { get; set; }

    public string Kdgroup { get; set; } = null!;

    public string? Nik { get; set; }

    public string? Nama { get; set; }

    public string? Email { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createby { get; set; }

    public DateTime? Updatedate { get; set; }

    public string? Updateby { get; set; }

    public virtual Masterupt? IduptNavigation { get; set; }
}
