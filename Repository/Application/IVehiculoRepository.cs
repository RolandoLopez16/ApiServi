using APISERVI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISERVI.Repository.Application
{
    public interface IVehiculoRepository
    {
        Task<int> AddAsync(Vehiculo entity);
        Task<int> DeleteAsync(int id);
        Task<IEnumerable<Vehiculo>> GetAllAsync();
        Task<Vehiculo> GetByIdAsync(int id);
        Task<int> UpdateAsync(Vehiculo entity);
    }
}
