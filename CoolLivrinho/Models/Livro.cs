namespace CoolLivrinho.Models
{
    public class Livro
    {
        public int LivroId { get; set; }

        public string Titulo { get; set; }

        public Autor? Autor { get; set; }
        public int AutorId { get; set; }

        public Categoria? Categoria { get; set; }
        public int CategoriaId { get; set; }

        public int AnoLancamento { get; set; }
    }
}
