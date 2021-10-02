using Microsoft.AspNetCore.Mvc;
using Site01.Database ;
using sistemadebancodepalavras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemadebancodepalavras.Library.Filters;

namespace sistemadebancodepalavras.Controllers
{
    [Login] //todas ações sejam influenciadas porem pode usar em um unico metodo
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
            return View(new Palavra());
        }
        [HttpPost]
        public IActionResult Cadastrar([FromForm] Palavra palavra)
        {
            if (ModelState.IsValid)
            {
                _db.Palavras.Add(palavra);
                _db.SaveChanges();


                TempData["Mensagem"] = "A palavra " + palavra.Nome +" foi cadastrada com sucesso!";


                return RedirectToAction("Index");
            }
           
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            Palavra palavra = _db.Palavras.Find(Id);


            return View("Cadastrar",palavra);
        }
        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)

        {
            if (ModelState.IsValid)
            {
                _db.Palavras.Update(palavra); //atualizando o endereço
                _db.SaveChanges(); //salvando


                TempData["Mensagem"] = "A palavra " + palavra.Nome + " foi atualizada com sucesso!";

                return RedirectToAction("Index");
            }

            return View("Cadastrar", palavra); // se der errado vai retornar o dado que o usuario preencheu
        }


        //palavra/Excluir/38
        //{controler}/{action}/{id?}
        [HttpGet] //excluir pode usar o http Get
        public IActionResult Excluir(int Id)
        {

            Palavra palavra = _db.Palavras.Find(Id);
            _db.Palavras.Remove(_db.Palavras.Find(Id));
            _db.SaveChanges();

            TempData["Mensagem"] = "A palavra " + palavra.Nome + " foi deletada com sucesso!";

            //todo registro do banco
            return Redirect("Index");
        }
    }
}
