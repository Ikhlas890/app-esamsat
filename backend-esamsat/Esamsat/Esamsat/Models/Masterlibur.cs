using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterlibur
{
    public int Idlibur { get; set; }

    public long Idkabkota { get; set; }

    public string Level { get; set; } = null!;

    public DateTime Tanggal { get; set; }

    public string? Namalibur { get; set; }

    public string? Ket { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterkabkotum IdkabkotaNavigation { get; set; } = null!;
}
