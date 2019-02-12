using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace monari.WebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CheckupController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "API läuft!";
        }
    }
}
