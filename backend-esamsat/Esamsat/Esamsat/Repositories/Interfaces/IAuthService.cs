using Esamsat.Models;
using static Esamsat.Dto.AuthDto;

namespace Esamsat.Services.Interfaces
{
    public interface IAuthService
    {
        // CREATE
        Task<Appuser> Register(RegisterRequest request);

        // READ
        Task<Appuser?> Login(LoginRequest request); // untuk autentikasi
        Task<Appuser?> GetUserByIdAsync(string userId); // baca user berdasarkan ID
        Task<List<Appuser>> GetAllUsersAsync(); // baca semua user

        // UPDATE
        Task<Appuser?> UpdateUserAsync(string userId, UpdateUserRequest req);

        // DELETE
        Task<bool> DeleteUserAsync(string userId);

        // LOGOUT
        Task<bool> Logout(string userId);
    }
}
