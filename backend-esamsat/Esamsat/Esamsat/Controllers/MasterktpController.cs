using Esamsat.Repositories.Implementations;
using Esamsat.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Esamsat.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MasterktpController : ControllerBase
    {
        private readonly IMasterktpRepository _repository;

        public MasterktpController(IMasterktpRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPaged([FromQuery] int page = 1, [FromQuery] int pageSize = 50)
        {
            var data = await _repository.GetPagedAsync(page, pageSize);
            return Ok(data);
        }

        [HttpGet("for-select")]
        public async Task<IActionResult> GetForSelect([FromQuery] string? query = null)
        {
            // Memanggil method di repository khusus untuk p-select / autocomplete
            var result = await _repository.GetForSelectAsync(query);
            return Ok(result);
        }

    }
}
