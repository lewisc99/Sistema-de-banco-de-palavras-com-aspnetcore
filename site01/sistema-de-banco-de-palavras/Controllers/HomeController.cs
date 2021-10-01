using Microsoft.AspNetCore.Mvc;
using sistemadebancodepalavras.Models;

namespace sistemadebancodepalavras.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([FromForm] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (usuario.Email == "luizdoidosonavida@gmail.com" || usuario.Email == "123456")
                {
                    return RedirectToAction("Index","Palavra");
                }
                else
                {
                    ViewBag.Mensagem = "Os dados informados são invalidos";
                    return View();
                }
            }
            else
            {
                return View();
            }

        }
    }
}
