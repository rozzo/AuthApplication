using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace AuthApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("BasicGet")]
        [AllowAnonymous]
        public string BasicGet()
        {
            return "Unsecured response";
        }

        [HttpGet("SecureGet")]
        public string SecureGet()
        {
            return "Secured response";
        }
    }
}
