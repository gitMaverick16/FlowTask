using FlowTask.DTOs;
using FlowTask.Models;
using FlowTask.Services;
using FlowTask.Validators;
using Microsoft.AspNetCore.Mvc;

namespace FlowTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        private readonly ISectionService _sectionService;
        public SectionController(ISectionService sectionService)
        {
            _sectionService = sectionService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _sectionService.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateSectionDTO section)
        {
            var validator = new CreateSectionValidator();
            var validateResult = validator.Validate(section);
            if (!validateResult.IsValid)
            {
                return BadRequest(validateResult.Errors.ToString());
            }
            return Ok(await _sectionService.Add(section));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(UpdateSectionDTO section)
        {
            var validator = new UpdateSectionValidator();
            var validateResult = validator.Validate(section);
            if (!validateResult.IsValid)
            {
                return BadRequest(validateResult.Errors.ToString());
            }
            var sectionSearched = await _sectionService.Get(section.Id.ToString());
            if (sectionSearched is null)
            {
                return NotFound();
            }
            return Ok(await _sectionService.Update(section));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var service = await _sectionService.Get(id);
            if (service is null)
            {
                return NotFound();
            }
            return Ok(await _sectionService.Delete(service));
        }
    }
}
