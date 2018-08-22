using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap04.Web.MVC.Models
{
    [Table("Carros")]
    public class Carro
    {        
        [Column("Id")]
        public int CarroId { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 8)]
        public string Placa { get; set; }

        [Required]
        public string Marca { get; set; }

        [Display(Name ="Ar Condicionado")]
        public bool ArCondicionado { get; set; }
    }
}