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
            var da = new FuncionarioDA();

            return da.GetFuncionarios();
        }

        [HttpPost]
        public ActionResult<Funcionario> Post(Funcionario funcionario)
        {
            var da = new FuncionarioDA();

            return da.Criar(funcionario);
        }

        [HttpPut("{id}")]
        public ActionResult<Funcionario> Put(int id, Funcionario funcionario)
        {
            var da = new FuncionarioDA();

            funcionario.IdFuncionario = id;

            return da.Editar(funcionario);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var da = new FuncionarioDA();

            da.Excluir(id);
        }
    }
}
