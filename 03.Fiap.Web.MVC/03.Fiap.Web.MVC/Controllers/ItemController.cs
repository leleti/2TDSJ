using _03.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03.Fiap.Web.MVC.Controllers
{
    public class ItemController : Controller
    {
        //Simular o banco de dados
        private static IList<Item> _banco = new List<Item>();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_banco); //envia a lista de itens para a tela
        }

        [HttpGet] //Abre a página do formulário
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost] //Recupera as informações do formulário
        public ActionResult Cadastrar(Item item)
        {
            _banco.Add(item); //cadastra no "banco"
            TempData["msg"] = "Item adicionado!"; //mensagem para a tela
            return RedirectToAction("Cadastrar"); //Redireciona para o cadastrar
        }
    }
}