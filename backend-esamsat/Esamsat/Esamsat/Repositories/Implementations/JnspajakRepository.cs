using Esamsat.Db;
using Esamsat.Models;
using Esamsat.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Esamsat.Repositories.Implementations
{
    public class JnspajakRepository : IJnspajakRepository
    {
        private readonly DataContext _context;

        public JnspajakRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Jnspajak>> GetAllAsync()
        {
            return await _context.Jnspajaks.ToListAsync();
        }
    }
}
