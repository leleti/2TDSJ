using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap06.Web.MVC.Controllers
{
    public class JogadorController : Controller
    {
        private FutebolContext _context = new FutebolContext();

        [HttpGet]
        public ActionResult Buscar(int? time)
        {
            var lista = _context.Jogadores.Include("Time")
                .Where(j => j.TimeId == time || time == null).ToList();
            CarregarComboTimes();
            return View("Listar", lista);
        }

        private void CarregarComboTimes()
        {
            //Enviar os times para o drowpdown
            var times = _context.Times.ToList();
            ViewBag.times = new SelectList(times, "TimeId", "Nome");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            CarregarComboTimes();
            //Include -> inclui a relação do jogador com o time na busca
            var lista = _context.Jogadores.Include("Time").ToList();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Buscar todos os times cadastrados
            var lista = _context.Times.ToList();
            //Passar a lista para a tela
            ViewBag.times = new SelectList(lista, "TimeId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador)
        {
            _context.Jogadores.Add(jogador);
            _context.SaveChanges();
            TempData["msg"] = "Jogador cadastrado";
            return RedirectToAction("Cadastrar");
        }
    }
}