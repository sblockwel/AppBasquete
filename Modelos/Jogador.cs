using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppBasquete.Models
{
    public class Jogador
    {        
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        [NotMapped]
        public int Idade { get => (int)((DateTime.Today - DataNasc).Days / 365); }
        public List<Jogo> Jogos { get; set; }
        public string Time { get; set; }
        public string Sexo { get; set; }
        public string Tecnico { get; set; }
        public string NumCamisa { get; set; }
        public override string ToString()
        {
            return Nome;
        }
    }
}