using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Models
{
    public class Treinador
    {
        public int TreinadorId { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
    }
}