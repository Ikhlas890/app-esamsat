using Esamsat.Db;
using Esamsat.Dto;
using Esamsat.Models;
using Esamsat.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Esamsat.Repositories.Implementations
{
    public class MasterbankRepository : IMasterbankRepository
    {
        private readonly DataContext _context;

        public MasterbankRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Masterbank>> GetAllAsync()
        {
            return await _context.Masterbanks.ToListAsync();
        }

        public async Task<Masterbank?> GetByIdAsync(int id)
        {
            return await _context.Masterbanks.FindAsync(id);
        }
    }
}
