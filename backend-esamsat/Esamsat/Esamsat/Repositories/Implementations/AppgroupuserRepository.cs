using Esamsat.Db;
using Esamsat.Models;
using Esamsat.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Esamsat.Repositories.Implementations
{
    public class AppgroupuserRepository : IAppgroupuserRepository
    {
        private readonly DataContext _context;

        public AppgroupuserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Appgroupuser>> GetAllAsync()
        {
            return await _context.Appgroupusers.ToListAsync();
        }

        public async Task<Appgroupuser?> GetByIdAsync(string kdgroup)
        {
            return await _context.Appgroupusers.FindAsync(kdgroup);
        }

        public async Task<Appgroupuser> CreateAsync(Appgroupuser group)
        {
            _context.Appgroupusers.Add(group);
            await _context.SaveChangesAsync();
            return group;
        }

        public async Task<Appgroupuser?> UpdateAsync(Appgroupuser group)
        {
            var existing = await _context.Appgroupusers.FindAsync(group.Kdgroup);
            if (existing == null) return null;

            existing.Nmgroup = group.Nmgroup;
            existing.Ket = group.Ket;
            existing.Updatedate = DateTime.UtcNow;
            existing.Updateby = group.Updateby;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteAsync(string kdgroup)
        {
            var group = await _context.Appgroupusers.FindAsync(kdgroup);
            if (group == null) return false;

            _context.Appgroupusers.Remove(group);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
