using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterbendahara
{
    public long Idbend { get; set; }

    public long Idpegawai { get; set; }

    public int Idbank { get; set; }

    public string Norek { get; set; } = null!;

    public string Namarek { get; set; } = null!;

    public string Jnsbend { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Jabatan { get; set; }

    public string? Pangkat { get; set; }

    public string? Uid { get; set; }

    public long? Koordinator { get; set; }

    public int? Idreknrc { get; set; }

    public string? Telepon { get; set; }

    public string? Ket { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterbank IdbankNavigation { get; set; } = null!;

    public virtual Masterpegawai IdpegawaiNavigation { get; set; } = null!;

    public virtual Masterreknrc? IdreknrcNavigation { get; set; }

    public virtual Masterupt? KoordinatorNavigation { get; set; }

    public virtual ICollection<Transst> Transsts { get; set; } = new List<Transst>();
}
