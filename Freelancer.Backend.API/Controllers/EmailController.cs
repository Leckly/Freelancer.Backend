using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Freelancer.Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost("sendEmail")]
        public async Task<ActionResult> SendEmail([FromBody] EmailDto emailDto)
        {
            await _emailService.SendEmail(emailDto);
            return Ok();
        }
    }
}
