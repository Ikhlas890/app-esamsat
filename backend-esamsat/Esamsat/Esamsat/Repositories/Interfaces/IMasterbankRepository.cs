using Esamsat.Dto;
using Esamsat.Models;

namespace Esamsat.Repositories.Interfaces
{
    public interface IMasterbankRepository
    {
        Task<IEnumerable<Masterbank>> GetAllAsync();
        Task<Masterbank?> GetByIdAsync(int id);
    }
}
