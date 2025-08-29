using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Business.Interfaces;
using Freelancer.Backend.Business.Services;
using Freelancer.Backend.Domain.Enums;
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
        public async Task<IActionResult> GetAll([FromQuery] int skip, [FromQuery] int take, [FromQuery] string? searchBar, [FromQuery] string[] tags,
            [FromQuery] JobStatus status, [FromQuery] int? minPrice, [FromQuery] DateOnly dateStart)
        {
            var jobs = await _jobService.GetAllAsync(skip, take, searchBar, tags, status, minPrice, dateStart);
            return Ok(jobs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var job = await _jobService.GetByIdAsync(id);
            return Ok(job);
        }

        [HttpGet("{userId}/all")]
        public async Task<IActionResult> GetByUserId(int userId)
        {
            var jobs = await _jobService.GetByUserIdAsync(userId);
            return Ok(jobs);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm] JobCreationRequest jobDto)
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
        public async Task<IActionResult> Update(int id, [FromBody] JobUpdateRequest jobDto)
        {
            await _jobService.UpdateAsync(id, jobDto);
            return Ok();
        }

        [HttpPost("downloadJobPhoto/{jobId}/{photoId}", Name = "DownloadJobPhoto")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> DownloadJobPhoto([FromRoute] int jobId, [FromRoute] int photoId)
        {
            var photoContent = await _jobService.GetJobPhoto(jobId, photoId);
            return File(photoContent.content, photoContent.contentType, photoContent.name);
        }

        [HttpPatch("changeJobStatus/{id}")]
        public async Task<IActionResult> ChangeJobStatus(int id)
        {
            await _jobService.UpdateJobStatus(id);
            return Ok();
        }
    }
}
