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
            var jobs = await _jobService.GetAllAsync(skip, take, searchBar, tags);
            return Ok(jobs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var job = await _jobService.GetByIdAsync(id);
            return Ok(job);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm] JobDto jobDto)
        {
            var job = await _jobService.AddAsync(jobDto);
            return Created("Add", job);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _jobService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, JobDto jobDto)
        {
            await _jobService.UpdateAsync(id, jobDto);
            return Ok();
        }
    }
}
