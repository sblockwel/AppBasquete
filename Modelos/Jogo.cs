using System.ComponentModel.DataAnnotations;

namespace AppBasquete.Models
{
    public class Jogo
    {
        private int placar;
        public int Id { get; set; }
        public int Placar
        {
            get => placar;            
            set
            {
                if (value < 0 && value > 1000)
                {
                    throw new System.Exception("O valor não pode ser inferior a 0 e não maior que 1000");
                }
                placar = value;
            }
        }
        public Jogador Jogador { get; set; }
    }
}