using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Freelancer.Backend.API.Controllers
{
    [Route("/api/users")]
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
        [ProducesResponseType(201)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> SignUp([FromForm] RegisterDTO registerDTO)
        {
            await _userService.SignUpAsync(registerDTO);
            return Created();
        }

        [HttpPost("downloadPhoto/{userId}", Name = "DownloadPhoto")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> DownloadPhoto([FromRoute] int userId)
        {
            var photoContent = await _userService.DownloadPhotoAsync(userId);
            return File(photoContent.content, photoContent.contentType, photoContent.name);
        }

        [HttpPost("login", Name = "SignInUser")]
        [ProducesResponseType(typeof(UserDTO), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> SignIn([FromBody] LoginDTO loginDTO)
        {
            var user = await _userService.SignInAsync(loginDTO);
            return Ok(user);
        }

        [HttpPost("signout", Name = "SingOutUser")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> LogOut()
        {
            await _userService.SignOutAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Update([FromBody] UpdateUserDto userDTO, [FromRoute] int id)
        {
            await _userService.UpdateAsync(userDTO, id);
            return Ok();
        }
    }
}
