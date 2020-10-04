using AppBasquete.Data;
using AppBasquete.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppBasquete
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PopularDados();
            Application.Run(new FormMain());            
        }

        public static void PopularDados()
        {
            var contexto = new ContextoApp();
            var jogador = new Jogador()
            {
                Id = 1,
                Nome = "Maria",
                DataNasc = DateTime.Parse("03/10/2005"),
                Sexo = "Feminino",
                Time = "Time 1",
                Tecnico = "Técnico 1",
                NumCamisa = "22"
            };
            if (!contexto.Jogadores.Any())
            {
                contexto.Jogadores.Add(jogador);
            }
            if (!contexto.Jogos.Any())
            {
                contexto.Jogos.Add(new Jogo()
                {
                    Jogador = jogador,
                    Placar = 12
                });

                contexto.Jogos.Add(new Jogo()
                {
                    Jogador = jogador,
                    Placar = 24
                });

                contexto.Jogos.Add(new Jogo()
                {
                    Jogador = jogador,
                    Placar = 10
                });

                contexto.Jogos.Add(new Jogo()
                {
                    Jogador = jogador,
                    Placar = 24
                });
                contexto.SaveChanges();
            }
        }
    }
}
