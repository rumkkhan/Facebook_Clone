using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
      

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
          return new string[] {"Value1", "value2"};
        }
    }
}
