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
                //so pode ser usado em um controlador, mas essa e um gambiarra de usar 
                //o controller fora de um controller.
                if(context.Controller != null)
                {
                   Controller controlador = context.Controller as Controller; //criar um controller

                    controlador.TempData["MensagemError"] = "Faça o Login para ter permissão de entrar nessa página!";

                }

                context.Result = new RedirectToActionResult("Login", "Home", null); //redirecionar para login localizado no controlador home


            }
        }
    }
}
