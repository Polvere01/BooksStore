using BooksStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BooksStore.Mapping
{
    public class AutorMap : EntityTypeConfiguration<Autor>
    {
        public AutorMap()
        {
            ToTable("Autor");
            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(30).IsRequired();
            HasMany(x => x.Livro).WithMany(x => x.Autor).Map(x => x.ToTable("LivroAutor"));
        }
    }
}