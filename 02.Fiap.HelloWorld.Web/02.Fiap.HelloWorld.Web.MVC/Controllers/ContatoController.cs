using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02.Fiap.HelloWorld.Web.MVC.Controllers
{
    public class ContatoController : Controller
    {
        //Abre a tela com o formulário
        [HttpGet]
        public ActionResult Enviar()
        {
            return View();
        }

        //Processa as informações do formulário
        [HttpPost]
        public ActionResult Enviar(string nome, string email)
        {
            return Content(nome + "  " + email);
        }

        [HttpGet]
        public ActionResult Receber()
        {
            return View();
        }
    }
}