using System;
using System.Collections.Generic;
using entr1.Models;

namespace entr1.DataAccess
{
    public class FuncionarioDA
    {
        public static List<Funcionario> _funcionarios;

        static FuncionarioDA()
        {
            _funcionarios = new List<Funcionario>
            {
                new Funcionario
                {
                    IdFuncionario = 1,
                    Nome = "Augusto Cezar",
                    Departamento = "Desenvolvimento",
                    Email = "a@iclips.com.br",
                    TelefonePrimario = "(32) 99876-5432",
                    AcessoAoIClips = true
                },
                new Funcionario
                {
                    IdFuncionario = 2,
                    Nome = "Karina Vasconcellos",
                    Departamento = "Customer Success",
                    Email = "a@iclips.com.br",
                    TelefonePrimario = "(32) 99876-5432",
                    AcessoAoIClips = false
                }
            };
        }

        public List<Funcionario> GetFuncionarios()
        {
            return _funcionarios;
        }

        public Funcionario Criar(Funcionario model)
        {
            model.IdFuncionario = _funcionarios.Count + 1;

            return model;
        }

        public Funcionario Editar(Funcionario model)
        {
            return model;
        }

        public void Excluir(int id)
        {
        }
    }
}