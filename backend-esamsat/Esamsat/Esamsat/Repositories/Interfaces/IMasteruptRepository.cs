using Esamsat.Dto;
using Esamsat.Models;

namespace Esamsat.Repositories.Interfaces
{
    public interface IMasteruptRepository
    {
        Task<IEnumerable<Masterupt>> GetAllAsync();
        Task<Masterupt?> GetByIdAsync(long id);
        Task<Masterupt> CreateAsync(CreateMasteruptDto dto);
        Task<Masterupt?> UpdateAsync(long id, UpdateMasterUptDto dto);
        Task<bool> DeleteAsync(long id);
    }
}
