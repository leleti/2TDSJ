using Fiap04.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap04.Web.MVC.Persistencia
{
    public class ConcessionariaContext : DbContext
    {
        public DbSet<Carro> Carros { get; set; }
    }
}