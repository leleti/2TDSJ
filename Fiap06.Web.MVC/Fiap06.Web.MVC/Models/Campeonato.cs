using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Models
{
    public class Campeonato
    {
        public int CampeonatoId { get; set; }
        public string Nome { get; set; }
        public int Rodadas { get; set; }

        //Relacionamentos
        public IList<Time> Times { get; set; }
    }
}