using Microsoft.AspNetCore.Mvc;
using APISERVI.Models;
using APISERVI.Repository.Application;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APISERVI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConductoresController : ControllerBase
    {
        private readonly IConductoresRepository _ConductoresRepository;

        public ConductoresController(IConductoresRepository ConductoresRepository)
        {
            _ConductoresRepository = ConductoresRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Conductor>> GetAll()
        {
            return await _ConductoresRepository.GetAllAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Conductor>> GetVehiculo(int id)
        {
            var conductor = await _ConductoresRepository.GetByIdAsync(id);
            if (conductor == null)
                return NotFound();
            return conductor;
        }

        [HttpPost]
        public async Task<ActionResult<Conductor>> PostVehiculo(Conductor Conductor)
        {
            var newConductor = await _ConductoresRepository.AddAsync(Conductor);
            return NoContent();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> PutVehiculo(int id, Conductor conductor)
        {
            var ConductorToUpdate = await _ConductoresRepository.GetByIdAsync(id);

            if (ConductorToUpdate == null)
                return NotFound();

            await _ConductoresRepository.UpdateAsync(conductor);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var conductorToDelete = await _ConductoresRepository.GetByIdAsync(id);

            if (conductorToDelete == null)
                return NotFound();

            await _ConductoresRepository.DeleteAsync(conductorToDelete.IdConductor);
            return NoContent();
        }
    }
}
