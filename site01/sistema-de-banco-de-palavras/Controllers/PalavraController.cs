using Microsoft.AspNetCore.Mvc;
using Site01.Database ;
using sistemadebancodepalavras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemadebancodepalavras.Library.Filters;
using X.PagedList;

namespace sistemadebancodepalavras.Controllers
{
    [Login] //todas ações sejam influenciadas porem pode usar em um unico metodo
    public class PalavraController : Controller
    {
        //listar todas as palavras do banco de dados.
        List<Nivel> niveis = new List<Nivel>();
        private DatabaseContext _db;
        public PalavraController(DatabaseContext db)
        {
            _db = db;

            niveis.Add(new Nivel() { Id = 1, Nome = "Fácil" });
            niveis.Add(new Nivel() { Id = 2, Nome = "Médio" });
            niveis.Add(new Nivel() { Id = 3, Nome = "Difícil" });
        }



        public IActionResult Index(int? page) //passamos um parametro page.
        {

            var pageNumber = page ?? 1; //se o resultado não for nulo.
            var palavras = _db.Palavras.ToList();

            var resultadoPaginado = palavras.ToPagedList(pageNumber, 5);
            //acima informa a pagina principal, e o segundo parametro e
            //quantidade de resultados da coluna por pagina (5).



            return View(resultadoPaginado);
            
            
        }

        //CRUD
        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.Nivel = niveis;
            return View(new Palavra());
        }
        [HttpPost]
        public IActionResult Cadastrar([FromForm] Palavra palavra)
        {
            ViewBag.Nivel = niveis;

            if (ModelState.IsValid)
            {

             
                _db.Palavras.Add(palavra);
                _db.SaveChanges();


                TempData["Mensagem"] = "A palavra " + palavra.Nome +" foi cadastrada com sucesso!";


                return RedirectToAction("Index");
            }
           
            return View(palavra);
        }

        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            ViewBag.Nivel = niveis;
            Palavra palavra = _db.Palavras.Find(Id);


            return View("Cadastrar",palavra);
        }
        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)

        {
            ViewBag.Nivel = niveis;
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
