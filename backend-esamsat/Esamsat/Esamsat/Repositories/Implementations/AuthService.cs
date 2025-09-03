using Esamsat.Db;
using Esamsat.Models;
using Microsoft.EntityFrameworkCore;
using static Esamsat.Dto.AuthDto;
using Esamsat.Services.Interfaces;
using Esamsat.Repositories.Implementations;

namespace Esamsat.Services.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly DataContext _context;
        private readonly EmailService _emailService;

        public AuthService(DataContext context, EmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        public async Task<Appuser> Register(RegisterRequest request)
        {
            if (await _context.Appusers.AnyAsync(u => u.Userid == request.Userid))
                throw new Exception("Userid sudah digunakan");

            var user = new Appuser
            {
                Userid = request.Userid,
                Pwd = HashPassword(request.Password),
                Nama = request.Nama,
                Email = request.Email,
                Kdgroup = request.Kdgroup,
                Kdtahap = "1",
                Idupt = 1,
                Idpeg = 0,
                Nik = "-",
                Createdate = DateTime.UtcNow,
                Createby = "system"
            };

            _context.Appusers.Add(user);
            await _context.SaveChangesAsync();

            // Kirim email notifikasi
            var subject = "Selamat Datang di Sistem Kami!";
            var body = $"Halo {user.Nama},<br>Selamat akun Anda telah berhasil dibuat.";
            await _emailService.KirimEmailAsync(user.Email, subject, body);

            return user;
        }

        public async Task<Appuser?> Login(LoginRequest request)
        {
            var user = await _context.Appusers.FirstOrDefaultAsync(u => u.Userid == request.Userid);
            if (user == null)
                return null;

            if (!VerifyPassword(request.Password, user.Pwd))
                return null;

            return user;
        }

        public async Task<Appuser?> UpdateUserAsync(string userId, UpdateUserRequest req)
        {
            var user = await _context.Appusers.FindAsync(userId);
            if (user == null) return null;

            if (!string.IsNullOrEmpty(req.Nama))
                user.Nama = req.Nama;

            if (!string.IsNullOrEmpty(req.Email) && req.Email != user.Email)
            {
                user.Email = req.Email;

                // Kirim email notifikasi
                var subject = "Email Anda Telah Diperbarui";
                var body = $"Halo {user.Nama},<br>Email Anda telah diperbarui menjadi: {user.Email}";
                await _emailService.KirimEmailAsync(user.Email, subject, body);
            }

            if (!string.IsNullOrEmpty(req.Kdgroup))
                user.Kdgroup = req.Kdgroup;

            if (!string.IsNullOrEmpty(req.Password))
                user.Pwd = HashPassword(req.Password);

            user.Updatedate = DateTime.UtcNow;
            user.Updateby = userId;

            await _context.SaveChangesAsync();
            return user;
        }

        // READ - Get user by ID
        public async Task<Appuser?> GetUserByIdAsync(string userId)
        {
            return await _context.Appusers.FindAsync(userId);
        }

        // READ - Get all users
        public async Task<List<Appuser>> GetAllUsersAsync()
        {
            return await _context.Appusers.ToListAsync();
        }

        // DELETE - Delete user
        public async Task<bool> DeleteUserAsync(string userId)
        {
            var user = await _context.Appusers.FindAsync(userId);
            if (user == null) return false;

            _context.Appusers.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public Task<bool> Logout(string userId)
        {
            return Task.FromResult(true);
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private bool VerifyPassword(string plainPassword, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(plainPassword, hashedPassword);
        }
    }
}
