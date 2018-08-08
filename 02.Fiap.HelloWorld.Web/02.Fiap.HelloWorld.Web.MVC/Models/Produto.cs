using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02.Fiap.HelloWorld.Web.MVC.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Estoque { get; set; }
        public int  Quantidade { get; set; }
    }
}