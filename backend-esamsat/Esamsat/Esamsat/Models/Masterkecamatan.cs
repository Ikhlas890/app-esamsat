using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterkecamatan
{
    public long Idkecamatan { get; set; }

    public long Idkabkota { get; set; }

    public string? Kdkecamatan { get; set; }

    public string Nmkecamatan { get; set; } = null!;

    public string Alamat { get; set; } = null!;

    public string Telepon { get; set; } = null!;

    public string? Fax { get; set; }

    public string Status { get; set; } = null!;

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterkabkotum IdkabkotaNavigation { get; set; } = null!;

    public virtual ICollection<Masterkelurahan> Masterkelurahans { get; set; } = new List<Masterkelurahan>();

    public virtual ICollection<Masterktp> Masterktps { get; set; } = new List<Masterktp>();

    public virtual ICollection<Masterwp> Masterwps { get; set; } = new List<Masterwp>();
}
