using sistemadebancodepalavras.Models;
using Site01.Database;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace sistemadebancodepalavras.Library.Validation
{
    public class UnicoNomePalavraAttribute :ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Palavra palavra = validationContext.ObjectInstance as Palavra; //pegando objeto por inteiro


            var _db = (DatabaseContext)validationContext.GetService(typeof(DatabaseContext));


            //verificação se já existe no banco de dados o registro que tenha o mesmo nome 
            // e o id seja o mesmo.

            var palavraBanco = _db.Palavras.Where(a => a.Nome == palavra.Nome && a.Id != palavra.Id).FirstOrDefault();

            if(palavraBanco ==null)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("a Palavra " + palavra.Nome + "  já existe no banco ");
            }
        }
    }
}
