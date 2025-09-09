using Esamsat.Dto;
using Esamsat.Models;

namespace Esamsat.Repositories.Interfaces
{
    public interface IMasterktpRepository
    {
        Task<IEnumerable<Masterktp>> GetAllAsync();
        Task<IEnumerable<Masterktp>> GetForSelectAsync(string? query = null);
        Task<IEnumerable<Masterktp>> GetPagedAsync(int pageNumber, int pageSize);
        Task<MasterktpDto?> GetByIdAsync(long id);

    }
}
