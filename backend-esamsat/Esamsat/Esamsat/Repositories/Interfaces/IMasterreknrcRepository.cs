using Esamsat.Dto;
using Esamsat.Models;

namespace Esamsat.Repositories.Interfaces
{
    public interface IMasterreknrcRepository
    {
        Task<IEnumerable<Masterreknrc>> GetAllAsync();
        // Method baru khusus untuk p-select / autocomplete
        Task<IEnumerable<Masterreknrc>> GetForSelectAsync(string? query = null);
        Task<Masterreknrc?> GetByIdAsync(int id);
        Task<Masterreknrc> CreateAsync(CreateMasterreknrcDto dto);
        Task<Masterreknrc?> UpdateAsync(int id, UpdateMasterreknrcDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
