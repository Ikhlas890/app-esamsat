using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterbank
{
    public int Idbank { get; set; }

    public string Kodebank { get; set; } = null!;

    public string Namabank { get; set; } = null!;

    public string? Akronimbank { get; set; }

    public string? Cabangbank { get; set; }

    public string? Alamatbank { get; set; }

    public string? Status { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual ICollection<Masterbendahara> Masterbendaharas { get; set; } = new List<Masterbendahara>();

    public virtual ICollection<Masterupt> Masterupts { get; set; } = new List<Masterupt>();
}
