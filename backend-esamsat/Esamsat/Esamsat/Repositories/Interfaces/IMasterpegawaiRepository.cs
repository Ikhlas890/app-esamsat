using Esamsat.Dto;
using Esamsat.Models;

namespace Esamsat.Repositories.Interfaces
{
    public interface IMasterpegawaiRepository
    {
        Task<IEnumerable<MasterpegawaiDto>> GetAllAsync();
        Task<MasterpegawaiDto?> GetByIdAsync(long id);
        Task<Masterpegawai> CreateAsync(CreateMasterpegawaiDto dto);
        Task<Masterpegawai?> UpdateAsync(long id, UpdateMasterpegawaiDto dto);
        Task<bool> DeleteAsync(long id);
    }
}
