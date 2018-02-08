using System.Collections.Generic;

namespace BooksStore.Models
{
    public class Autor
    {
        public Autor()
        {
            this.Livro = new List<Livro>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Livro> Livro { get; set; }
    }
}