using BooksStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BooksStore.Mapping
{
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            ToTable("Categoria");

            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(30).IsRequired();

            HasMany(x => x.Livro).WithRequired(x => x.Categoria);
        }
    }
}