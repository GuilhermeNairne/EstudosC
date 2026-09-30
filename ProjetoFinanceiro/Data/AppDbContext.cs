using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ProjetoFinanceiro.Models;

namespace ProjetoFinanceiro.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Painel> Paineis { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Movimento> Movimentos { get; set; }
        
    }
}
