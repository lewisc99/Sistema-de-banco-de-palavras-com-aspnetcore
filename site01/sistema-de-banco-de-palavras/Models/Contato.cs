using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace sistemadebancodepalavras.Models
{
    public class Contato
    {
        [Required(ErrorMessage ="O campo nome e obrigatorio")]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage ="O email e obrigatorio preencher")]
        [MaxLength(70,ErrorMessage ="o campo deve ter no maximo 70 caracteres")]
        [EmailAddress(ErrorMessage =" O campo E-mail e invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage ="O assunto deve ser preeenchido")]
        [MaxLength(70, ErrorMessage = "o campo deve ter no maximo 70 caracteres")]
        public string Assunto { get; set; }

        [MaxLength(2000, ErrorMessage = "o campo deve ter no maximo 70 caracteres")]
        [Required(ErrorMessage ="A mensagem deve ser preenchida")]
        public  string Mensagem { get; set; }
    }
}
