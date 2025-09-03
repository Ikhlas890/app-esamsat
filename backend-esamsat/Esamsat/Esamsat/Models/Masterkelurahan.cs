using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterkelurahan
{
    public long Idkelurahan { get; set; }

    public long Idkecamatan { get; set; }

    public string? Kdkelurahan { get; set; }

    public string Nmkelurahan { get; set; } = null!;

    public string Alamat { get; set; } = null!;

    public string Telepon { get; set; } = null!;

    public string? Kodepos { get; set; }

    public string Status { get; set; } = null!;

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterkecamatan IdkecamatanNavigation { get; set; } = null!;

    public virtual ICollection<Masterktp> Masterktps { get; set; } = new List<Masterktp>();

    public virtual ICollection<Masterrw> Masterrws { get; set; } = new List<Masterrw>();

    public virtual ICollection<Masterwp> Masterwps { get; set; } = new List<Masterwp>();
}
