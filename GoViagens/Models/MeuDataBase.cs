using Microsoft.EntityFrameworkCore;

namespace GoViagens.Models
{
    public class MeuDataBase : DbContext
    {

        public DbSet<Destino> Destinos { get; set; }

        public DbSet<Promocao> Promocao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=GoViagens;Integrated Security=True");
        }
    }
}
