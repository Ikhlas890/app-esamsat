using Esamsat.Models;

namespace Esamsat.Repositories.Interfaces
{
    public interface IMasterkabkotumRepository
    {
        Task<IEnumerable<Masterkabkotum>> GetAllAsync();
    }
}
