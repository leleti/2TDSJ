using _02.Fiap.HelloWorld.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02.Fiap.HelloWorld.Web.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        [HttpGet]    
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Produto produto)
        {
            //Enviando informações para a página
            ViewBag.nome = produto.Nome;
            TempData["msg"] = "Produto cadastrado!";
            return View();
            //return Content(produto.Nome + " " + produto.Quantidade + " "
            //    + produto.Estoque + " " + produto.Valor);
        }
    }
}