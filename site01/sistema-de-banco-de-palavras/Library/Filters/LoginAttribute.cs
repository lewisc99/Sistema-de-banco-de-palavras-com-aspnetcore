using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc; //para redirecionar 


namespace sistemadebancodepalavras.Library.Filters
{
    public class LoginAttribute : ActionFilterAttribute
    {

        public override void OnActionExecuted(ActionExecutedContext context) //variavel de entrada
        {
           
            if (context.HttpContext.Session.GetString("Login") == null) //se a sessão não existir  e porque
            {
                context.Result = new RedirectToActionResult("Login", "Home", null); //redirecionar para login localizado no controlador home


            }
        }
    }
}
