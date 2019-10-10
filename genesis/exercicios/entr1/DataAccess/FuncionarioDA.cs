using System;
using System.Collections.Generic;
using entr1.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace entr1.DataAccess
{
    public class FuncionarioDA
    {
        public static List<Funcionario> _funcionarios;

        public List<Funcionario> GetFuncionarios()
        {
            using (var context = new IClipsDbContext())
            {
                return context.Funcionarios.ToList();
            }
        }

        public Funcionario Criar(Funcionario model)
        {
            using (var context = new IClipsDbContext())
            {
                context.Funcionarios.Add(model);
                context.SaveChanges();

                return model;
            }
        }

        public Funcionario Editar(Funcionario model)
        {
            using (var context = new IClipsDbContext())
            {
                var entity = context.Funcionarios.First(f => f.IdFuncionario == model.IdFuncionario);

                entity.Nome = model.Nome;
                entity.Email = model.Email;
                entity.Departamento = model.Departamento;
                entity.DataNascimento = model.DataNascimento;
                entity.TelefonePrimario = model.TelefonePrimario;
                entity.TelefoneSecundario = model.TelefoneSecundario;
                entity.Login = model.Login;
                entity.Senha = model.Senha;
                entity.AcessoAoIClips = model.AcessoAoIClips;
                entity.AtivoNaAgencia = model.AtivoNaAgencia;
                
                context.SaveChanges();

                return model;
            }
        }

        public void Excluir(int id)
        {
            using (var context = new IClipsDbContext())
            {
                var model = context.Funcionarios.First(f => f.IdFuncionario == id);
                context.Remove(model);

                context.SaveChanges();
            }
        }
    }
}