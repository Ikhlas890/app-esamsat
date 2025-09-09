using Esamsat.Db;
using Esamsat.Dto;
using Esamsat.Models;
using Esamsat.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Esamsat.Repositories.Implementations
{
    public class MasterreknrcRepository : IMasterreknrcRepository
    {
        private readonly DataContext _context;

        public MasterreknrcRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Masterreknrc>> GetAllAsync()
        {
            return await _context.Masterreknrcs.ToListAsync();
        }

        // Method baru khusus untuk p-select
        public async Task<IEnumerable<Masterreknrc>> GetForSelectAsync(string? query = null)
        {
            var q = _context.Masterreknrcs.AsQueryable();

            if (!string.IsNullOrEmpty(query))
            {
                q = q.Where(r => r.Nmrek.Contains(query));
            }

            return await q
                .OrderBy(r => r.Nmrek)
                .Take(50) // batasi 50 record supaya tidak lemot
                .ToListAsync();
        }

        public async Task<Masterreknrc?> GetByIdAsync(int id)
        {
            return await _context.Masterreknrcs.FindAsync(id);
        }

        public async Task<Masterreknrc> CreateAsync(CreateMasterreknrcDto dto)
        {
            var entity = new Masterreknrc
            {
                Idreknrc = dto.Idreknrc,
                Mtglevel = dto.Mtglevel,
                Kdrek = dto.Kdrek,
                Nmrek = dto.Nmrek,
                Type = dto.Type
            };

            _context.Masterreknrcs.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Masterreknrc?> UpdateAsync(int id, UpdateMasterreknrcDto dto)
        {
            var entity = await _context.Masterreknrcs.FindAsync(id);
            if (entity == null) return null;

            entity.Mtglevel = dto.Mtglevel;
            entity.Kdrek = dto.Kdrek;
            entity.Nmrek = dto.Nmrek;
            entity.Type = dto.Type;

            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _context.Masterreknrcs.FindAsync(id);
            if (entity == null) return false;

            _context.Masterreknrcs.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
