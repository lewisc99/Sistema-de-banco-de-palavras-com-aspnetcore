using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemadebancodepalavras.Models;

namespace sistemadebancodepalavras.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ReceberContato([FromForm] Contato contato)
        {
            return new ContentResult() { Content = $" nome: {contato.Nome}, email: {contato.Email}, assunto: {contato.Assunto }, mensagem: {contato.Mensagem}" };
        }
      /*  public IActionResult ReceberContato()
        {
            // se for pelo method post usamos o = Request.Form
            // se for pelo Get usamos o = Request.Query/Request.Querystring

            Contato contato = new Contato();


            contato.Nome = Request.Form["nome"];
            contato.Email = Request.Form["email"];
            contato.Assunto = Request.Form["assunto"];
            contato.Mensagem = Request.Form["mensagem"];

            return new ContentResult() { Content = $" nome: {contato.Nome}, email: {contato.Email}, assunto: {contato.Assunto }, mensagem: {contato.Mensagem}" };
        } */


    }
}
