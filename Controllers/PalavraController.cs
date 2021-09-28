using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            return View();
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
            return View();
        }
        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)

        {
            return View();
        }
        [HttpGet] //excluir pode usar o http Get
        public IActionResult Excluir(int id)
        {

            //todo registro do banco
            return Redirect("Index");
        }
    }
}
