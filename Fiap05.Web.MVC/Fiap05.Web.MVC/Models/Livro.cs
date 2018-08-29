using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap05.Web.MVC.Models
{
    public class Livro
    {       
        public int LivroId { get; set; }

        [Required]
        public string Titulo { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Disponivel { get; set; }
    }
}