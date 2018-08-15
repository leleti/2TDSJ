using _03.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03.Fiap.Web.MVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logar(Usuario usuario)
        {
            if (usuario.Login == "FIAP" && usuario.Senha == "FIAP2018")
            {
                ViewBag.churros = usuario.Login;//Envia o login para a tela
                return View("Home"); //Home.cshtml
            }
            else
            {
                TempData["msg"] = "Usuário e/ou senha inválidos";//Envia msg para a tela
                //return View();//Logar.cshtml
                return View("Index");  //Index.cshtml
            }
        }
    }
}