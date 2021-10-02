using System;
using System.Collections.Generic;
using System.Linq;


using System.ComponentModel.DataAnnotations;

namespace sistemadebancodepalavras.Models
{
    public class Usuario
    {
        [EmailAddress(ErrorMessage = " O campo E-mail e invalido")]
        [Required(ErrorMessage ="O campo email e obrigatorio preencher")]
        public string Email { get; set; }

        [Required(ErrorMessage ="O campo senha e obrigatorio preencher")]
        [MinLength(5,ErrorMessage ="A senha deve ter no minimo 5 caracteres")]
        public string Senha { get; set; }

    }
}
