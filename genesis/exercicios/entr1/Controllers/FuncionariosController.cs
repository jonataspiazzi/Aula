using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using entr1.Models;
using entr1.DataAccess;

namespace entr1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<List<Funcionario>> Get()
        {
            return new FuncionarioDA().GetFuncionarios();
        }
    }
}
