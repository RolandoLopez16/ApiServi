using APISERVI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISERVI.Repository.Application
{
    public interface IConductoresRepository
    {
        Task<int> AddAsync(Conductor entity);
        Task<int> DeleteAsync(int id);
        Task<IEnumerable<Conductor>> GetAllAsync();
        Task<Conductor> GetByIdAsync(int id);
        Task<int> UpdateAsync(Conductor entity);
    }
}
