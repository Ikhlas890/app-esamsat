using Esamsat.Models;

namespace Esamsat.Repositories.Interfaces
{
    public interface IAppgroupuserRepository
    {
        Task<IEnumerable<Appgroupuser>> GetAllAsync();
        Task<Appgroupuser?> GetByIdAsync(string kdgroup);
        Task<Appgroupuser> CreateAsync(Appgroupuser group);
        Task<Appgroupuser?> UpdateAsync(Appgroupuser group);
        Task<bool> DeleteAsync(string kdgroup);
    }
}
