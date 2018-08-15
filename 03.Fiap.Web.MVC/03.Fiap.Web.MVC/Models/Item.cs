using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _03.Fiap.Web.MVC.Models
{
    public class Item
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        [Display(Name ="Maior idade")]
        public bool MaiorIdade { get; set; }
    }
}