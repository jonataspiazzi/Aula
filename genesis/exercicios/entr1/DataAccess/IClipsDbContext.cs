using System;
using System.Collections.Generic;
using entr1.Models;
using MySql.Data.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;

namespace entr1.DataAccess
{
    public class IClipsDbContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=iclipsdb;user=root;password=");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario);
                entity.Property(e => e.Nome).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Email).HasMaxLength(30);
                entity.Property(e => e.Departamento).HasMaxLength(30);
                entity.Property(e => e.DataNascimento);
                entity.Property(e => e.TelefonePrimario).HasMaxLength(20);
                entity.Property(e => e.TelefoneSecundario).HasMaxLength(20);
                entity.Property(e => e.Login).HasMaxLength(20);
                entity.Property(e => e.Senha).HasMaxLength(20);
                entity.Property(e => e.AcessoAoIClips);
                entity.Property(e => e.AtivoNaAgencia);
            });
        }
    }
}