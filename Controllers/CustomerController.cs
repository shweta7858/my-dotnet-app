using Mera_yani_shweta_ka_app.Data;
using Mera_yani_shweta_ka_app.Interface;
using Mera_yani_shweta_ka_app.models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mera_yani_shweta_ka_app.Controllers
{
    [Route("user")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _userService;
        private readonly AppDbContext _context;

        public CustomerController(ICustomerRepository userService, AppDbContext context)
        {
            _userService = userService;
            _context = context;
            
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] Customer customer)
        {
            await _userService.AddNewUser(customer); // ✅ properly awaited
            return Ok(customer);
        }



    }
}
