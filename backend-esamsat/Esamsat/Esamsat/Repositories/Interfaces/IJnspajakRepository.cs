using Esamsat.Models;

namespace Esamsat.Repositories.Interfaces
{
    public interface IJnspajakRepository
    {
        Task<IEnumerable<Jnspajak>> GetAllAsync();
    }
}
