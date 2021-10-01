using sistemadebancodepalavras.Models;

using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

namespace sistemadebancodepalavras.Library.Mail
{
    public class EnviarEmail
    {

        public static void EnviarMensagemContato(Contato contato)
        {

            string conteudo = $" nome: {contato.Nome}, email: {contato.Email}, assunto: {contato.Assunto }, mensagem: {contato.Mensagem}";


            MailMessage mensagem = new MailMessage();


            mensagem.From = new MailAddress("luizdoidosonavida@gmail.com");
            mensagem.To.Add("luizdoidosonavida@gmail.com");
            mensagem.Subject = "Formulario de contato";

            mensagem.IsBodyHtml = true;
            mensagem.Body = "<h1> Formulario de contato</h1> <br />" + conteudo;




            SmtpClient smtp = new SmtpClient(Constants.ServidorSMTP,Constants.PortaSMTP); 
             smtp.UseDefaultCredentials = false; 
            smtp.EnableSsl = true;

            smtp.Credentials = new NetworkCredential(Constants.Usuario,Constants.Senha);







            // para enviar

            smtp.Send(mensagem);
    }
    }
}
