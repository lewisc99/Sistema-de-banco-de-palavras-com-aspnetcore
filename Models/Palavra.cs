using Microsoft.AspNetCore.Mvc;


namespace sistemadebancodepalavras.Models
{
    public class Palavra 
    {
     
        public int Id { get; set; }
        public string Nome { get; set; }

        //1-facil, 2-medio, 3-dificil
        public byte Nivel { get; set; }

    }
}
