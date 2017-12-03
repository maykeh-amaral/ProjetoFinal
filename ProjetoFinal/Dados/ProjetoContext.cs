using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Models;

namespace ProjetoFinal.Dados
{
    public class ProjetoContext : DbContext
    {
        public ProjetoContext(DbContextOptions<ProjetoContext> options) : base(options)
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Errollments> Errollments { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Enderecos> Enderecos { get; set; }
        public DbSet<Fornecedores> Fornecedores { get; set; }
        public DbSet<Produtos> Produtos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().ToTable("Usuarios");
            modelBuilder.Entity<Errollments>().ToTable("Enrollments");
            modelBuilder.Entity<Clientes>().ToTable("Clientes");
            modelBuilder.Entity<Enderecos>().ToTable("Enderecos");
            modelBuilder.Entity<Fornecedores>().ToTable("Fornecedores");
            modelBuilder.Entity<Produtos>().ToTable("Produtos");

        }
    }
}
