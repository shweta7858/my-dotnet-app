using Mera_yani_shweta_ka_app.Interface;
using Mera_yani_shweta_ka_app.models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mera_yani_shweta_ka_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authService;

        public AuthController(IAuthRepository authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            try
            {
                var token = _authService.Login(model);
                return Ok(new { token });
            }
            catch (Exception ex)
            {
                return Unauthorized(new { message = ex.Message });
            }
        }
    }
}
