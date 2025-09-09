namespace Esamsat.Dto
{
    public class MasterrekdDto
    {
        public int Idrekd { get; set; }

        public int? Idparent { get; set; }

        public string? Mtglevel { get; set; }

        public string Kdrek { get; set; } = null!;

        public string? Nmrek { get; set; }

        public string? Kdjnspjk { get; set; }

        public string? Type { get; set; }

        public string? Status { get; set; }
        public string? Createby { get; set; }
    }

    public class CreateMasterrekdDto
    {
        public int Idrekd { get; set; }

        public int? Idparent { get; set; }

        public string? Mtglevel { get; set; }

        public string Kdrek { get; set; } = null!;

        public string? Nmrek { get; set; }

        public string? Kdjnspjk { get; set; }

        public string? Type { get; set; }

        public string? Status { get; set; }
        public string? Createby { get; set; }
    }
    public class UpdateMasterrekdDto
    {
        public int Idrekd { get; set; }

        public int? Idparent { get; set; }

        public string? Mtglevel { get; set; }

        public string Kdrek { get; set; } = null!;

        public string? Nmrek { get; set; }

        public string? Kdjnspjk { get; set; }

        public string? Type { get; set; }

        public string? Status { get; set; }
        public string? Createby { get; set; }
    }
}
