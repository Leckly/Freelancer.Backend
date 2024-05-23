using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Business.Interfaces;
using Freelancer.Backend.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace Freelancer.Backend.API.Controllers
{
    [Route("/api/rates")]
    [Tags("Rates")]
    [ApiController]
    public class RateController : ControllerBase
    {
        private readonly IRateService _rateService;

        public RateController(IRateService rateService)
        {
            _rateService = rateService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Add([FromBody] RateDto rateDto)
        {
            await _rateService.AddAsync(rateDto);

            return Created("Add", default);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete(int id)
        {
            await _rateService.DeleteAsync(id);

            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllUsers([FromQuery] int id)
        {
            var ratings = await _rateService.GetAllAsync(id);

            return Ok(ratings);
        }
    }
}
