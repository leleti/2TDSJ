using Fiap05.Web.MVC.Models;
using Fiap05.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap05.Web.MVC.Controllers
{
    public class LivroController : Controller
    {
        private BibliotecaContext _context = new BibliotecaContext();

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            //Busca o livro
            var livro = _context.Livros.Find(id);
            //Remover o livro
            _context.Livros.Remove(livro);
            _context.SaveChanges();
            TempData["msg"] = "Livro removido!";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Editar(Livro livro)
        {
            //Atualiza no banco de dados
            _context.Entry(livro).State = EntityState.Modified;
            _context.SaveChanges();
            //mensagem
            TempData["msg"] = "Livro atualizado!";
            //redirect
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var livro = _context.Livros.Find(id);
            return View(livro);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Busca os livros no banco de dados
            var lista = _context.Livros.ToList();
            //Retorna a página com a lista de livros
            return View(lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
            TempData["msg"] = "Livro cadastrado!";
            return RedirectToAction("Cadastrar");
        }
    }
}