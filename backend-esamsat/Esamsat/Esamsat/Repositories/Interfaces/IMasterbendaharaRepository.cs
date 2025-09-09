using Esamsat.Dto;
using Esamsat.Models;

namespace Esamsat.Repositories.Interfaces
{
    public interface IMasterbendaharaRepository
    {
        Task<IEnumerable<MasterbendaharaDto>> GetAllAsync();
        Task<MasterbendaharaDto?> GetByIdAsync(long id);
        Task<Masterbendahara> CreateAsync(createMasterbendaharaDto dto);
        Task<Masterbendahara?> UpdateAsync(long id, UpdateMasterbendaharaDto dto);
        Task<bool> DeleteAsync(long id);
    }
}
