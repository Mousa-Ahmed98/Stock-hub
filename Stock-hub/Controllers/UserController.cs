using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Stock_hub.Application.Interfaces;
using Stock_hub.DTOS;

namespace Stock_hub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegisterDTO userRegisterDTO)
        {
            if (ModelState.IsValid)
            {
                IdentityResult res = await _userService.Register(userRegisterDTO);
                if (res.Succeeded)
                {
                    return Ok("Created successfully");
                }
                return BadRequest(res.Errors.First());
            }

            return BadRequest(ModelState);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDTO userLoginDTO)
        {
            if (ModelState.IsValid)
            {
                var res = await _userService.Login(userLoginDTO);
                if (res != null)
                {
                    return Ok(res);
                }
                return Unauthorized();
            }
            return BadRequest(ModelState);
        }

        }
}
