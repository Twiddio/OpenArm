using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Backend.API.Controllers
{
    [ApiController]
    public class ArmAPI : ControllerBase
    {

        [HttpGet("Rungcode")]
        public string Get()
        {
            return "Hello";
        }
    }
}
