namespace Esamsat.Dto
{
    public class AppgroupuserDto
    {
        public string Kdgroup { get; set; } = null!;
        public string Nmgroup { get; set; } = null!;
        public string? Ket { get; set; }
    }

    public class CreateAppgroupuserDto
    {
        public string Kdgroup { get; set; } = null!;
        public string Nmgroup { get; set; } = null!;
        public string? Ket { get; set; }
    }

    public class UpdateAppgroupuserDto
    {
        public string Nmgroup { get; set; } = null!;
        public string? Ket { get; set; }
    }
}
