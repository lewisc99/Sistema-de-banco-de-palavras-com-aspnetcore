using Microsoft.AspNetCore.Mvc;
using sistemadebancodepalavras.Database;
using sistemadebancodepalavras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemadebancodepalavras.Controllers
{
    public class PalavraController : Controller
    {
        //listar todas as palavras do banco de dados.

        private DatabaseContext _db;
        public PalavraController(DatabaseContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {

            var palavras = _db.Palavras.ToList();
            return View(palavras);
            
            
        }

        //CRUD
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar([FromForm] Palavra palavra)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar()
        {
            return View("Cadastrar");
        }
        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)

        {
            return View("Cadastrar");
        }
        [HttpGet] //excluir pode usar o http Get
        public IActionResult Excluir(int id)
        {

            //todo registro do banco
            return Redirect("Index");
        }
    }
}
