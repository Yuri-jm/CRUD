using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MVC_Projeto;

namespace MVC_Projeto
{
    public class Context : DbContext
    {

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Categoria> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server = (localdb)\mssqllocaldb;Database=MVC_Projeto;Integrated Security=True");
        }
        public DbSet<MVC_Projeto.Produto> Produto { get; set; }
    }
}
