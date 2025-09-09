namespace Esamsat.Dto
{
    public class MasterkabkotumDto
    {
        public long Idkabkota { get; set; }

        public long Idprovinsi { get; set; }

        public string? Kdkabkota { get; set; }

        public string Nmkabkota { get; set; } = null!;

        public string Akronim { get; set; } = null!;

        public string Ibukota { get; set; } = null!;

        public string Status { get; set; } = null!;

        public string Bpkbid { get; set; } = null!;

        public string? Createby { get; set; }

        public DateTime? Createdate { get; set; }

        public string? Updateby { get; set; }

        public DateTime? Updatedate { get; set; }
    }
}
