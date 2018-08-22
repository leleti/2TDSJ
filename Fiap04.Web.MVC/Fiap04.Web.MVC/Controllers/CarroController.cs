using Fiap04.Web.MVC.Models;
using Fiap04.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap04.Web.MVC.Controllers
{
    public class CarroController : Controller
    {
        private ConcessionariaContext _context = new ConcessionariaContext();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_context.Carros.ToList());
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = new List<string>();
            lista.Add("FIAT");
            lista.Add("Honda");
            lista.Add("Hyundai");

            //Enviar a lista para a tela criar o select
            ViewBag.marcas = new SelectList(lista);

            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Carro carro)
        {
             _context.Carros.Add(carro);
            _context.SaveChanges(); //commit
            TempData["msg"] = "Carro registrado!";
            return RedirectToAction("Cadastrar");
        }
        
    }
}