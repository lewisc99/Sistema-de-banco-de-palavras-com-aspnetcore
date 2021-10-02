using Microsoft.AspNetCore.Mvc;
using sistemadebancodepalavras.Library.Validation;
using System.ComponentModel.DataAnnotations;

namespace sistemadebancodepalavras.Models
{
    public class Palavra 
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage ="O campo Nome e obrigatorio")]
        [MaxLength(15, ErrorMessage = "O campo Nome precisa ter no maximo 15 caracteres")]
        [UnicoNomePalavra]
        public string Nome { get; set; }

        //1-facil, 2-medio, 3-dificil
       
        public byte? Nivel { get; set; }

    }
}
