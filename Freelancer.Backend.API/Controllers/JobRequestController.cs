using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Business.Interfaces;
using Freelancer.Backend.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Freelancer.Backend.API.Controllers
{
    [Route("/api/jobRequests")]
    [Tags("JobRequests")]
    [ApiController]
    public class JobRequestController : ControllerBase
    {
        private readonly IJobRequestService _jobRequestService;

        public JobRequestController(IJobRequestService jobRequestService)
        {
            _jobRequestService = jobRequestService;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAll([FromQuery] int skip, [FromQuery] int take, [FromQuery] string? searchBar, [FromQuery] string[] tags)
        //{
        //    var jobRequests = await _jobRequestService.GetAllAsync();
        //    return Ok(jobRequests);
        //}

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] JobRequestAddRequest jobRequestAddRequest)
        {
            if (jobRequestAddRequest == null)
            {
                return BadRequest("Job request data is required.");
            }
            var createdJobRequest = await _jobRequestService.AddAsync(jobRequestAddRequest.UserId, jobRequestAddRequest.JobId);
            return Created(nameof(AddAsync), createdJobRequest);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _jobRequestService.DeleteAsync(id);
            return NoContent();
        }

        [HttpPut("{userId}/{jobId}")]
        public async Task<IActionResult> UpdateAsync(int userId, int jobId, [FromBody] JobRequestStatus status)
        {
            if (!Enum.IsDefined(typeof(JobRequestStatus), status))
            {
                return BadRequest("Invalid job request status.");
            }
            await _jobRequestService.UpdateAsync(userId, jobId, status);
            return NoContent();
        }
    }
}
