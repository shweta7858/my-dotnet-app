using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mera_yani_shweta_ka_app.Controllers
{
    [Route("/test-hl")]
    [ApiController]
    public class HealthController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetHealthStatus()
        {
            return Ok(new { status = "Healthy", timestamp = DateTime.UtcNow });
        }



    }
}
