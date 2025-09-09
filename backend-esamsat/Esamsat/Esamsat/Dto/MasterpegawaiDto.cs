namespace Esamsat.Dto
{
    public class MasterpegawaiDto
    {
        public long Idpegawai { get; set; }

        public long? Idktp { get; set; }

        public string Nip { get; set; } = null!;

        public string? Nik { get; set; }

        public string Nama { get; set; } = null!;

        public long Idupt { get; set; }
        public string Nmupt { get; set; } = null!; // Dari tabel MASTERUPT

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
    }

    public class CreateMasterpegawaiDto
    {

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
    }

    public class UpdateMasterpegawaiDto
    {

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

        public string? Updateby { get; set; }

        public DateTime? Updatedate { get; set; }
    }
}
