using Microsoft.AspNetCore.Mvc;
using ProjectManagerApi.DTOs;
using ProjectManagerApi.Services.Interfaces;

namespace ProjectManagerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService) => _authService = authService;

        [HttpPost("register")]
        public IActionResult Register(RegisterDto dto)
        {
            var token = _authService.Register(dto);
            return Ok(new { token });
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto dto)
        {
            var token = _authService.Login(dto);
            return Ok(new { token });
        }
    }
}
