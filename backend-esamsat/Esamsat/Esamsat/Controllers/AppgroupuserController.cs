using Microsoft.AspNetCore.Mvc;
using Esamsat.Repositories.Interfaces;
using Esamsat.Models;
using Esamsat.Dto;

namespace Esamsat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppgroupuserController : ControllerBase
    {
        private readonly IAppgroupuserRepository _repository;

        public AppgroupuserController(IAppgroupuserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppgroupuserDto>>> GetAll()
        {
            var groups = await _repository.GetAllAsync();
            var result = groups.Select(g => new AppgroupuserDto
            {
                Kdgroup = g.Kdgroup,
                Nmgroup = g.Nmgroup,
                Ket = g.Ket
            });
            return Ok(result);
        }

        [HttpGet("{kdgroup}")]
        public async Task<ActionResult<AppgroupuserDto>> GetById(string kdgroup)
        {
            var group = await _repository.GetByIdAsync(kdgroup);
            if (group == null) return NotFound();

            return Ok(new AppgroupuserDto
            {
                Kdgroup = group.Kdgroup,
                Nmgroup = group.Nmgroup,
                Ket = group.Ket
            });
        }

        [HttpPost]
        public async Task<ActionResult<AppgroupuserDto>> Create(CreateAppgroupuserDto dto)
        {
            var newGroup = new Appgroupuser
            {
                Kdgroup = dto.Kdgroup,
                Nmgroup = dto.Nmgroup,
                Ket = dto.Ket,
                Createdate = DateTime.UtcNow,
                Createby = "system" // nanti ambil dari user login
            };

            var created = await _repository.CreateAsync(newGroup);
            return CreatedAtAction(nameof(GetById), new { kdgroup = created.Kdgroup }, dto);
        }

        [HttpPut("{kdgroup}")]
        public async Task<ActionResult<AppgroupuserDto>> Update(string kdgroup, UpdateAppgroupuserDto dto)
        {
            var updateGroup = new Appgroupuser
            {
                Kdgroup = kdgroup,
                Nmgroup = dto.Nmgroup,
                Ket = dto.Ket,
                Updateby = "system" // nanti ambil dari user login
            };

            var updated = await _repository.UpdateAsync(updateGroup);
            if (updated == null) return NotFound();

            return Ok(new AppgroupuserDto
            {
                Kdgroup = updated.Kdgroup,
                Nmgroup = updated.Nmgroup,
                Ket = updated.Ket
            });
        }

        [HttpDelete("{kdgroup}")]
        public async Task<IActionResult> Delete(string kdgroup)
        {
            var deleted = await _repository.DeleteAsync(kdgroup);
            if (!deleted) return NotFound();

            return NoContent();
        }
    }
}
