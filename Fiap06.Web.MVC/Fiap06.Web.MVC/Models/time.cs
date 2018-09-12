using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Models
{
    public class Time
    {
        public int TimeId { get; set; }
        public string Nome { get; set; }
        public long Torcedores { get; set; }

        //Relacionamentos
        public Treinador Treinador { get; set; }
        public int? TreinadorId { get; set; }

        public IList<Jogador> Jogadores { get; set; }

        public IList<Campeonato> Campeonatos { get; set; }
    }
}