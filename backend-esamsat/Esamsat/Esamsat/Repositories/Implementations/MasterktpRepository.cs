using Esamsat.Db;
using Esamsat.Dto;
using Esamsat.Models;
using Esamsat.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Esamsat.Repositories.Implementations
{
    public class MasterktpRepository : IMasterktpRepository
    {
        private readonly DataContext _context;

        public MasterktpRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Masterktp>> GetAllAsync()
        {
            return await _context.Masterktps.ToListAsync();
        }

        public async Task<IEnumerable<Masterktp>> GetPagedAsync(int pageNumber, int pageSize)
        {
            return await _context.Masterktps
                .AsNoTracking() // Lebih cepat karena tidak perlu tracking
                .OrderBy(k => k.Idktp) 
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        // Method baru khusus untuk p-select
        public async Task<IEnumerable<Masterktp>> GetForSelectAsync(string? query = null)
        {
            var q = _context.Masterktps.AsQueryable();

            if (!string.IsNullOrEmpty(query))
            {
                q = q.Where(r => r.Nama.Contains(query));
            }

            return await q
                .OrderBy(r => r.Nama)

              //.Skip((pageNumber - 1) * pageSize)
              //.Take(pageSize)

                .Take(50) // batasi 50 record supaya tidak lemot
                .ToListAsync();
        }

        public async Task<MasterktpDto?> GetByIdAsync(long id)
        {
            return await _context.Masterktps
                .AsNoTracking()
                .Where(k => k.Idktp == id)
                .Select(k => new MasterktpDto
                {
                    Idktp = k.Idktp,
                    Nama = k.Nama
                    // tambahkan properti lain sesuai kebutuhan
                })
                .FirstOrDefaultAsync();
        }

    }
}
