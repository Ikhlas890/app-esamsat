using System;
using System.Collections.Generic;

namespace Esamsat.Models;

public partial class Masterpegawai
{
    public long Idpegawai { get; set; }

    public long? Idktp { get; set; }

    public string Nip { get; set; } = null!;

    public string? Nik { get; set; }

    public string Nama { get; set; } = null!;

    public long Idupt { get; set; }

    public string Status { get; set; } = null!;

    public string? Jabatan { get; set; }

    public string? Pangkat { get; set; }

    public string? Golongan { get; set; }

    public string? Uid { get; set; }

    public string? Telepon { get; set; }

    public string? Createby { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Updateby { get; set; }

    public DateTime? Updatedate { get; set; }

    public virtual Masterktp? IdktpNavigation { get; set; }

    public virtual Masterupt IduptNavigation { get; set; } = null!;

    public virtual ICollection<Masterbendahara> Masterbendaharas { get; set; } = new List<Masterbendahara>();

    public virtual ICollection<Masterjabttd> Masterjabttds { get; set; } = new List<Masterjabttd>();

    public virtual ICollection<Masterkaupt> Masterkaupts { get; set; } = new List<Masterkaupt>();

    public virtual ICollection<Masterupt> MasteruptBendaharaNavigations { get; set; } = new List<Masterupt>();

    public virtual ICollection<Masterupt> MasteruptKepalaNavigations { get; set; } = new List<Masterupt>();

    public virtual ICollection<Masterupt> MasteruptKoordinatorNavigations { get; set; } = new List<Masterupt>();
}
