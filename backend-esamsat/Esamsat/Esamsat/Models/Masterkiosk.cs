using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterkiosk
{
    public int Idkios { get; set; }

    public int? Idparent { get; set; }

    public string Kodekiosk { get; set; } = null!;

    public string Datakiosk { get; set; } = null!;

    public string Level { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }
}
