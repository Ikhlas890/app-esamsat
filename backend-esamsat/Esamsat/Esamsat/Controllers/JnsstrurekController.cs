using Esamsat.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Esamsat.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JnsstrurekController : ControllerBase
    {
        private readonly IJnsstrurekRepository _repository;

        public JnsstrurekController(IJnsstrurekRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _repository.GetAllAsync();
            return Ok(result);
        }
    }
}
