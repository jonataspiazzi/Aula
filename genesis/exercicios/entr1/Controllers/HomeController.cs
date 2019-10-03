using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace entr1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "home" };
        }
    }
}