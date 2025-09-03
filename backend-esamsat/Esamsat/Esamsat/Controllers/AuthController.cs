using Microsoft.AspNetCore.Mvc;
using Esamsat.Models;
using Esamsat.Services.Interfaces;
using static Esamsat.Dto.AuthDto;

namespace Esamsat.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { message = "Data tidak valid." });

            try
            {
                var user = await _authService.Register(request);
                return Ok(new
                {
                    message = "User berhasil didaftarkan.",
                    user = new
                    {
                        user.Userid,
                        user.Nama,
                        user.Email,
                        user.Kdgroup
                    }
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    message = "Gagal melakukan register.",
                    error = ex.InnerException?.Message ?? ex.Message
                });
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { message = "Data tidak valid." });

            var user = await _authService.Login(request);
            if (user == null)
                return Unauthorized(new { message = "User atau password salah" });

            HttpContext.Session.SetString("UserId", user.Userid);
            HttpContext.Session.SetString("UserName", user.Nama ?? "");
            HttpContext.Session.SetString("Kdgroup", user.Kdgroup);

            return Ok(new
            {
                message = "Login berhasil",
                user = new
                {
                    user.Userid,
                    user.Nama,
                    user.Kdgroup
                }
            });
        }

        [HttpPut("users/{userId}")]
        public async Task<IActionResult> UpdateUser(string userId, [FromBody] UpdateUserRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { message = "Data tidak valid." });

            var updatedUser = await _authService.UpdateUserAsync(userId, request);
            if (updatedUser == null)
                return NotFound(new { message = "User tidak ditemukan." });

            return Ok(new
            {
                message = "User berhasil diperbarui.",
                user = MapToUserResponse(updatedUser)
            });
        }

        [HttpGet("me")]
        public IActionResult GetLoggedUser()
        {
            var userId = HttpContext.Session.GetString("UserId");
            var nama = HttpContext.Session.GetString("UserName");
            var kdgroup = HttpContext.Session.GetString("Kdgroup");

            if (string.IsNullOrEmpty(userId))
                return Unauthorized(new { message = "Belum login." });

            return Ok(new
            {
                userid = userId,
                nama = nama,
                kdgroup = kdgroup
            });
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            Response.Cookies.Delete(".AspNetCore.Session");
            return Ok(new { message = "Logout berhasil" });
        }

        // === NEW: READ ALL USERS (DTO) ===
        [HttpGet("users")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _authService.GetAllUsersAsync();
            var userDtos = users.ConvertAll(MapToUserResponse);
            return Ok(userDtos);
        }

        // === NEW: READ USER BY ID (DTO) ===
        [HttpGet("users/{userId}")]
        public async Task<IActionResult> GetUserById(string userId)
        {
            var user = await _authService.GetUserByIdAsync(userId);
            if (user == null)
                return NotFound(new { message = "User tidak ditemukan." });

            return Ok(MapToUserResponse(user));
        }

        // === NEW: DELETE USER ===
        [HttpDelete("users/{userId}")]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            var result = await _authService.DeleteUserAsync(userId);
            if (!result)
                return NotFound(new { message = "User tidak ditemukan atau gagal dihapus." });

            return Ok(new { message = "User berhasil dihapus." });
        }

        // === Helper: Mapping ke UserResponse DTO ===
        private static UserResponse MapToUserResponse(Appuser user)
        {
            return new UserResponse
            {
                Userid = user.Userid,
                Nama = user.Nama,
                Email = user.Email,
                Kdgroup = user.Kdgroup,
                Kdtahap = user.Kdtahap,
                Idupt = user.Idupt,
                Idpeg = user.Idpeg,
                Nik = user.Nik,
                Createdate = user.Createdate,
                Createby = user.Createby,
                Updatedate = user.Updatedate,
                Updateby = user.Updateby
            };
        }
    }
}
