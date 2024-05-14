using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Freelancer.Backend.API.Controllers
{
    [Route("/api/jobs")]
    [Tags("Jobs")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] int skip, [FromQuery] int take, [FromQuery] string searchBar, [FromQuery] string[] tags)
        {

            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm] JobDto jobDto)
        {
            return Created();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id)
        {
            return Ok();
        }
    }
}
