using Esamsat.Db;
using Esamsat.Models;
using Esamsat.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Esamsat.Repositories.Implementations
{
    public class JnsstrurekRepository : IJnsstrurekRepository
    {
        private readonly DataContext _context;

        public JnsstrurekRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Jnsstrurek>> GetAllAsync()
        {
            return await _context.Jnsstrureks.ToListAsync();
        }
    }
}
