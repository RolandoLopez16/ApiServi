using Microsoft.AspNetCore.Mvc;
using APISERVI.Models;
using APISERVI.Repository.Application;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISERVI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehiculosController : ControllerBase
    {
        private readonly IVehiculoRepository _vehiculoRepository;

        public VehiculosController(IVehiculoRepository vehiculoRepository)
        {
            _vehiculoRepository = vehiculoRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Vehiculo>> GetAll()
        {
            return await _vehiculoRepository.GetAllAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Vehiculo>> GetVehiculo(int id)
        {
            var vehiculo = await _vehiculoRepository.GetByIdAsync(id);
            if (vehiculo == null)
                return NotFound();
            return vehiculo;
        }

        [HttpPost]
        public async Task<ActionResult<Vehiculo>> PostVehiculo(Vehiculo vehiculo)
        {
            var newVehiculo = await _vehiculoRepository.AddAsync(vehiculo);
            return NoContent();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> PutVehiculo(int id, Vehiculo vehiculo)
        {
            var vehiculoToUpdate = await _vehiculoRepository.GetByIdAsync(id);

            if (vehiculoToUpdate == null)
                return NotFound();

            await _vehiculoRepository.UpdateAsync(vehiculo);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var vehiculoToDelete = await _vehiculoRepository.GetByIdAsync(id);

            if (vehiculoToDelete == null)
                return NotFound();

            await _vehiculoRepository.DeleteAsync(vehiculoToDelete.IdVehiculo);
            return NoContent();
        }
    }
}
