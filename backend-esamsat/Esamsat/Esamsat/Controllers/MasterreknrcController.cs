using Esamsat.Dto;
using Esamsat.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Esamsat.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MasterreknrcController : ControllerBase
    {
        private readonly IMasterreknrcRepository _repository;

        public MasterreknrcController(IMasterreknrcRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _repository.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("for-select")]
        public async Task<IActionResult> GetForSelect([FromQuery] string? query = null)
        {
            // Memanggil method di repository khusus untuk p-select / autocomplete
            var result = await _repository.GetForSelectAsync(query);
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _repository.GetByIdAsync(id);
            if (result == null)
                return NotFound(new { message = "Data tidak ditemukan" });
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateMasterreknrcDto dto)
        {
            var created = await _repository.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Idreknrc }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateMasterreknrcDto dto)
        {
            var updated = await _repository.UpdateAsync(id, dto);
            if (updated == null)
                return NotFound(new { message = "Data tidak ditemukan" });
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _repository.DeleteAsync(id);
            if (!deleted)
                return NotFound(new { message = "Data tidak ditemukan" });
            return NoContent();
        }
    }
}
