using Fiap06.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Persistencia
{
    public class FutebolContext : DbContext
    {
        public DbSet<Time> Times { get; set; }
        public DbSet<Campeonato> Campeonatos { get; set; }
        public DbSet<Treinador> Treinadores { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
    }
}