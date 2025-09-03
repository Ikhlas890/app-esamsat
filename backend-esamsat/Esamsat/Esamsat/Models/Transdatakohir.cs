using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Transdatakohir
{
    public long Idkohir { get; set; }

    public DateTime Masaawal { get; set; }

    public DateTime Masaakhir { get; set; }

    public DateTime Tglpenetapan { get; set; }

    public string Penagih { get; set; } = null!;

    public long Idwp { get; set; }

    public DateTime? Tglkurangbayar { get; set; }

    public string? Ket { get; set; }

    public long? Idupt { get; set; }

    public string? Skrupt { get; set; }

    public string? Validjr { get; set; }

    public string? Validjrby { get; set; }

    public string? Validpol { get; set; }

    public string? Validpolby { get; set; }

    public string? Ntpd { get; set; }

    public DateTime? Tglntpd { get; set; }

    public string? Idbank { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterupt? IduptNavigation { get; set; }

    public virtual Masterwp IdwpNavigation { get; set; } = null!;

    public virtual ICollection<Transpenetapan> Transpenetapans { get; set; } = new List<Transpenetapan>();
}
