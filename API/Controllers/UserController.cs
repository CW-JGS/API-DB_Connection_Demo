using Microsoft.AspNetCore.Mvc;
using API.Models;
namespace API.Controllers
{
    class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<DemoData> get()
        {
            throw new NotImplementedException();
        }
        [HttpGet("{uuid}")]
        public DemoData get(Guid uuid)
        {
            throw new NotImplementedException();
        }
        [HttpPost]
        public void post([FromBody] string values)
        {
            throw new NotImplementedException();
        }
    }
}