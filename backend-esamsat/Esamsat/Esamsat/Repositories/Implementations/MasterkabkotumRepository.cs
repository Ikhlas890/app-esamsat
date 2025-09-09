using Esamsat.Db;
using Esamsat.Models;
using Esamsat.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Esamsat.Repositories.Implementations
{
    public class MasterkabkotumRepository : IMasterkabkotumRepository
    {
        private readonly DataContext _context;

        public MasterkabkotumRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Masterkabkotum>> GetAllAsync()
        {
            return await _context.Masterkabkota.ToListAsync();
        }
    }
}
