using AppBasquete.Models;
using Microsoft.EntityFrameworkCore;

namespace AppBasquete.Data
{
    public class ContextoApp : DbContext
    {
        public ContextoApp()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = AppBasquete.db");
        }
        public virtual DbSet<Jogo> Jogos { get; set; }
        public virtual DbSet<Jogador> Jogadores { get; set; }
    }
}
