using Microsoft.EntityFrameworkCore;
using sistemadebancodepalavras.Models;

namespace sistemadebancodepalavras.Database
{
    public class DatabaseContext: DbContext
    {

        public DbSet<Palavra> Palavras { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) :base(options)
        {
            //garante que o banco seja criado.
            Database.EnsureCreated();

           
        }

    }
}
