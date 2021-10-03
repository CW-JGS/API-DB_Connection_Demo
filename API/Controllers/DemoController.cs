using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {
        private static List<Demo> testdata = new List<Demo>()
        {
          new Demo(){did = 1, data1 = "demo data 1", data2 = "demo data 1.1"},
          new Demo(){did = 2, data1 = "demo data 2", data2 = "demo data 2.1"}
        };

        private readonly ILogger<DemoController> _logger;

        public DemoController(ILogger<DemoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Demo> Get()
        {
            DemoDatabaseHandler db = new DemoDatabaseHandler();
            return db.GetAllDemoFromDB();
        }
    }
}
