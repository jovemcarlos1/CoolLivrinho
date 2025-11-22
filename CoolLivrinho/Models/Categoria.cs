using System.ComponentModel.DataAnnotations;

namespace Bibliotech.Models
{
    public class Categoria
    {
        [Display(Name = ("Categoria"))]
        public int CategoriaId { get; set; }

        public string Nome { get; set; }
    }
}
