using AppBasquete.Models;
using Microsoft.EntityFrameworkCore;

namespace AppBasquete.Data
{
    /// <summary>
    /// Classe responsável por gerenciar o contexto de conexão com o banco de dados.
    /// </summary>
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
