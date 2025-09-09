using Esamsat.Dto;
using Esamsat.Models;

namespace Esamsat.Repositories.Interfaces
{
    public interface IMasterrekdRepository
    {
        Task<IEnumerable<Masterrekd>> GetAllAsync();
        Task<Masterrekd?> GetByIdAsync(int id);
        Task<Masterrekd> CreateAsync(CreateMasterrekdDto dto);
        Task<Masterrekd?> UpdateAsync(int id, UpdateMasterrekdDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
