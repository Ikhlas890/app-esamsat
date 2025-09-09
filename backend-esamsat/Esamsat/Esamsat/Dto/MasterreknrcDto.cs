namespace Esamsat.Dto
{
    public class MasterreknrcDto
    {
        public int Idreknrc { get; set; }

        public string? Mtglevel { get; set; }

        public string Kdrek { get; set; } = null!;

        public string? Nmrek { get; set; }

        public string? Type { get; set; }
    }

    public class CreateMasterreknrcDto
    {
        public int Idreknrc { get; set; }

        public string? Mtglevel { get; set; }

        public string Kdrek { get; set; } = null!;

        public string? Nmrek { get; set; }

        public string? Type { get; set; }
    }

    public class UpdateMasterreknrcDto
    {
        public int Idreknrc { get; set; }

        public string? Mtglevel { get; set; }

        public string Kdrek { get; set; } = null!;

        public string? Nmrek { get; set; }

        public string? Type { get; set; }
    }
}
