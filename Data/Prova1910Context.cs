using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prova1910.Pages.Funcionarios;
using Prova1910.Pages.Alunos;

namespace Prova1910.Data
{
    public class Prova1910Context : DbContext
    {
        public Prova1910Context (DbContextOptions<Prova1910Context> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-JGGG844\SQLEXPRESS; Initial Catalog=autoescola; Integrated Security = true");
        }

        public DbSet<Prova1910.Pages.Funcionarios.Funcionario> Funcionario { get; set; }

        public DbSet<Prova1910.Pages.Alunos.Aluno> Aluno { get; set; }
    }
}
