using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistemadebancodepalavras.Models;
using sistemadebancodepalavras.Library.Mail;

namespace sistemadebancodepalavras.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Contato = new Contato();
            return View();
        }


        public IActionResult ReceberContato([FromForm] Contato contato)
        {

            if(ModelState.IsValid)
            {
                // return new ContentResult() { Content = $" nome: {contato.Nome}, email: {contato.Email}, assunto: {contato.Assunto }, mensagem: {contato.Mensagem}" };
                ViewBag.Contato = new Contato();

                EnviarEmail.EnviarMensagemContato(contato);

                ViewBag.Mensagem = "Mensagem enviada com sucesso";
                return View("Index");

            }
            else
            {

                ViewBag.Contato = contato;
                return View("Index");




            }

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
