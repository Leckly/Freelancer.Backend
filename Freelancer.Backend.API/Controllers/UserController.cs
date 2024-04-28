using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Freelancer.Backend.API.Controllers
{
    [Route("/users")]
    [Tags("Users")]
    [ApiController]
    public sealed class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("signin", Name = "SignUpUser")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> SignUp([FromBody] RegisterDTO registerDTO)
        {
            await _userService.SignUpAsync(registerDTO);
            return Created();
        }

        [HttpPost("login", Name = "SignInUser")]
        [ProducesResponseType(typeof(UserDTO), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> SignIn([FromBody] LoginDTO loginDTO)
        {
            await _userService.SignInAsync(loginDTO);
            return Ok();
        }

        [HttpPost("signout", Name = "SingOutUser")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> LogOut()
        {
            await _userService.SignOutAsync();
            return Ok();
        }

    }
}
