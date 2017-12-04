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
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Fornecedores> Fornecedores { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Enrollments> Enrollments { get; set; }

    }
}
