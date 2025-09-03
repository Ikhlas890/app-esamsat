using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Jnsprogresif
{
    public int Kdprogresif { get; set; }

    public decimal Progresif { get; set; }

    public decimal Progresifr4 { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }
}
