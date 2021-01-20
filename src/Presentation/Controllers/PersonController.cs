using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace curso_RestApi1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        private readonly ILogger<PersonController> _logger;
        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{firstName}/{lastName}")]
        public IActionResult Get(string firstName, string lastName)
        {
            return BadRequest("Invalid Input");
        }
    }
}