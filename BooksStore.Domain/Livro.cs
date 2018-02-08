using System;
using System.Collections.Generic;

namespace BooksStore.Models
{
    public class Livro
    {
        public Livro()
        {
            this.Autor = new List<Autor>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ISBN { get; set; }
        public DateTime Datalancamento { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public ICollection<Autor> Autor { get; set; } 
    }
}