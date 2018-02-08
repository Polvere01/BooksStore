using BooksStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BooksStore.Mapping
{
    public class LivroMap : EntityTypeConfiguration<Livro>
    {
        public LivroMap()
        {

            ToTable("Livro");
            HasKey(x => x.Id);
            Property(x => x.Nome).HasMaxLength(30).IsRequired();
            Property(x => x.ISBN).HasMaxLength(30).IsRequired();  
            Property(x => x.Datalancamento);
        }
    }
}