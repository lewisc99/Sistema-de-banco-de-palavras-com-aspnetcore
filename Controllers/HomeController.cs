using Microsoft.AspNetCore.Mvc;


namespace sistemadebancodepalavras.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
