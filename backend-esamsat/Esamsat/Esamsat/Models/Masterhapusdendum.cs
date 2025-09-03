using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterhapusdendum
{
    public int Idhapusdenda { get; set; }

    public string Jenis { get; set; } = null!;

    public string Uraian { get; set; } = null!;

    public DateTime? Awal { get; set; }

    public DateTime? Akhir { get; set; }

    public decimal? Nilai { get; set; }

    public string? Satuan { get; set; }

    public string? Ket { get; set; }

    public string? Status { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }
}
