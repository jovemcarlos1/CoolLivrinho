using System.ComponentModel.DataAnnotations;

namespace Bibliotech.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        
        [Display(Name = ("Título"))]
        public string Titulo { get; set; }

        public Autor? Autor { get; set; }
        [Display(Name = ("Autor"))]
        public int AutorId { get; set; }

        public Categoria? Categoria { get; set; }

        [Display(Name = ("Categoria"))]
        public int CategoriaId { get; set; }
        
        [Display(Name = ("Ano de lançamento"))]
        public int AnoLancamento { get; set; }

        public string? CapaUrl { get; set; }

    }
}
