using BooksStore.Mapping;
using BooksStore.Models;
using System.Data.Entity;

namespace BooksStore
{
    public class BooksStoresDataContext: DbContext
    {
        public BooksStoresDataContext()
            :base("BooksStore")
        {

        }
        public DbSet<Livro> Livro { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AutorMap());
            modelBuilder.Configurations.Add(new LivroMap());
            modelBuilder.Configurations.Add(new CategoriaMap());
        }
    }
}