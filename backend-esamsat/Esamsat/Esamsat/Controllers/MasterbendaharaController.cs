using Esamsat.Dto;
using Esamsat.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Esamsat.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MasterbendaharaController : ControllerBase
    {
        private readonly IMasterbendaharaRepository _repository;

        public MasterbendaharaController(IMasterbendaharaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _repository.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var result = await _repository.GetByIdAsync(id);
            if (result == null)
                return NotFound(new { message = "Data tidak ditemukan" });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] createMasterbendaharaDto dto)
        {
            var created = await _repository.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Idbend }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, [FromBody] UpdateMasterbendaharaDto dto)
        {
            var updated = await _repository.UpdateAsync(id, dto);
            if (updated == null)
                return NotFound(new { message = "Data tidak ditemukan" });
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var deleted = await _repository.DeleteAsync(id);
            if (!deleted)
                return NotFound(new { message = "Data tidak ditemukan" });
            return NoContent();
        }
    }
}
