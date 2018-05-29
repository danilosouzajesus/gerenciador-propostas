using Microsoft.EntityFrameworkCore;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class LojaContext : DbContext
    {
        public DbSet<Provider> Produtos { get; set; }

        public LojaContext()
        {  }

        public LojaContext(DbContextOptions<LojaContext> options): base(options)
        {  }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
            }
        }
    }
}