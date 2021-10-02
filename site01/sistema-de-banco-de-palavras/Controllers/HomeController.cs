using Microsoft.AspNetCore.Http;
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
                if (usuario.Email == "luizdoidosonavida@gmail.com" || usuario.Senha == "123456")
                {


                    //add Session 
                    //HttpContext.Session.SetString("login", "true"); //true e string e não bolean
                    // HttpContext.Session.SetInt32("UserID",32);
                    //serializar objet para > string



                    //Ler Session
                    //string login = HttpContext.Session.GetString("Login");
                    HttpContext.Session.SetString("Login", "true");
                    return RedirectToAction("Index", "Palavra");
                }
                else
                {
                    ViewBag.Mensagem = "Os dados informados são inválidos!";
                    return View();
                }
            }
            else
            {
                return View();
            }

        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}