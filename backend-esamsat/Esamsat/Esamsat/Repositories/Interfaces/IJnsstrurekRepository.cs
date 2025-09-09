using Esamsat.Models;

namespace Esamsat.Repositories.Interfaces
{
    public interface IJnsstrurekRepository
    {
        Task<IEnumerable<Jnsstrurek>> GetAllAsync();
    }
}
