namespace Esamsat.Dto
{
    public class MasterbendaharaDto
    {
        public long Idbend { get; set; }

        public long Idpegawai { get; set; }

        public int Idbank { get; set; }

        public string Norek { get; set; } = null!;

        public string Namarek { get; set; } = null!;

        public string Jnsbend { get; set; } = null!;

        public string Status { get; set; } = null!;

        public string? Jabatan { get; set; } // dari MASTERPEGAWAI

        public string? Pangkat { get; set; } // dari MASTERPEGAWAI

        public string? Uid { get; set; }

        public long? Koordinator { get; set; } // ID Koordinator (IDUPT)

        public int? Idreknrc { get; set; }

        public string? Telepon { get; set; }

        public string? Ket { get; set; }

        public string? Createby { get; set; }

        public DateTime? Createdate { get; set; }

        public string? Updateby { get; set; }

        public DateTime? Updatedate { get; set; }

        // JOIN DATA
        public string? Nama { get; set; }       // dari MASTERPEGAWAI
        public string? Namabank { get; set; }   // dari MASTERBANK
        public string? Nmrek { get; set; }      // dari MASTERREKNRC
        public string? NamaKoordinator { get; set; } // Tambahan: Nmupt dari MASTERUPT
    }

    public class createMasterbendaharaDto
    {
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
    }

    public class UpdateMasterbendaharaDto
    {
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
        public string? Updateby { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
