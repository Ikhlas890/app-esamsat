namespace Esamsat.Dto
{
    public class MasteruptDto
    {
        public long Idupt { get; set; }

        public long? Idparent { get; set; }

        public string Kdupt { get; set; } = null!;

        public string Nmupt { get; set; } = null!;

        public string? Kdlevel { get; set; }

        public string Type { get; set; } = null!;

        public string? Akroupt { get; set; }

        public string? Alamat { get; set; }

        public string? Telepon { get; set; }

        public int? Idbank { get; set; }

        public long? Idkabkota { get; set; }

        public long? Kepala { get; set; }

        public long? Koordinator { get; set; }

        public long? Bendahara { get; set; }

        public string? Status { get; set; }

        public string? Createby { get; set; }
        public DateTime? Createdate { get; set; }

        public string? Updateby { get; set; }

        public DateTime? Updatedate { get; set; }
    }

    public class CreateMasteruptDto
    {
        public long? Idparent { get; set; }
        public string Kdupt { get; set; } = null!;
        public string Nmupt { get; set; } = null!;
        public string? Kdlevel { get; set; }
        public string Type { get; set; } = null!;
        public string? Akroupt { get; set; }
        public string? Alamat { get; set; }
        public string? Telepon { get; set; }
        public int? Idbank { get; set; }
        public long? Idkabkota { get; set; }
        public long? Kepala { get; set; }
        public long? Koordinator { get; set; }
        public long? Bendahara { get; set; }
        public string? Status { get; set; }
        public string? Createby { get; set; } // hanya createby
    }

    public class UpdateMasterUptDto
    {
        public long? Idparent { get; set; }
        public string Kdupt { get; set; } = null!;
        public string Nmupt { get; set; } = null!;
        public string? Kdlevel { get; set; }
        public string Type { get; set; } = null!;
        public string? Akroupt { get; set; }
        public string? Alamat { get; set; }
        public string? Telepon { get; set; }
        public int? Idbank { get; set; }
        public long? Idkabkota { get; set; }
        public long? Kepala { get; set; }
        public long? Koordinator { get; set; }
        public long? Bendahara { get; set; }
        public string? Status { get; set; }
        public string? Updateby { get; set; } // hanya updateby
    }

}
