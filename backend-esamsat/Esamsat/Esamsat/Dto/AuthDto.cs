namespace Esamsat.Dto
{
    public class AuthDto
    {
        public class RegisterRequest
        {
            public string Userid { get; set; }
            public string Password { get; set; }
            public string Nama { get; set; }
            public string Email { get; set; }
            public string Kdgroup { get; set; }
        }

        public class LoginRequest
        {
            public string Userid { get; set; }
            public string Password { get; set; }
        }

        public class UpdateUserRequest
        {
            public string Nama { get; set; }
            public string Email { get; set; }
            public string Kdgroup { get; set; }
            public string? Password { get; set; } // Optional
        }

        // READ RESPONSE (disesuaikan)
        public class UserResponse
        {
            public string Userid { get; set; }
            public long? Idupt { get; set; }
            public string Kdtahap { get; set; }
            public long? Idpeg { get; set; }
            public string Kdgroup { get; set; }
            public string? Nik { get; set; }
            public string? Nama { get; set; }
            public string? Email { get; set; }
            public DateTime? Createdate { get; set; }
            public string? Createby { get; set; }
            public DateTime? Updatedate { get; set; }
            public string? Updateby { get; set; }
        }

        public class DeleteUserRequest
        {
            public string Userid { get; set; }
        }
    }
}
