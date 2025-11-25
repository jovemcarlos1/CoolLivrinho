using Microsoft.EntityFrameworkCore;

namespace Bibliotech.Data
{
    public class LivroContext : DbContext
    {
        public LivroContext(DbContextOptions<LivroContext> options) : base(options)
        {
        }
        public DbSet<Models.Livro> Livros { get; set; }
        public DbSet<Models.Autor> Autores { get; set; }
        public DbSet<Models.Categoria> Categorias { get; set; } 
        public DbSet<Models.User> Usuarios { get; set; }
    }
}
