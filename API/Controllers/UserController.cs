using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.middleware.DB;
namespace API.Controllers
{
    class UserController : ControllerBase
    {
        private DBRequestHandler _DBRH;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
            _DBRH = new DBRequestHandler();
        }
        [HttpGet]
        public IEnumerable<DemoData> get()
        {
            return _DBRH.GetAllUsers();
        }
        [HttpGet("{uuid}")]
        public DemoData get(string uuid)
        {
            return _DBRH.GetUserByUUID(uuid);
        }
        [HttpPost]
        public void post([FromBody] string values)
        {
            // figure out how to serialise and de-serialise JSON data
        }
    }
}