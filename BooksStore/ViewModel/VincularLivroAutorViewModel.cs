using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BooksStore.ViewModel
{
    public class VincularLivroAutorViewModel
    {
        [Required(ErrorMessage = "*")]
        public int LivroId { get; set; }
        [Required(ErrorMessage = "*")]
        public int AutorId { get; set; }
    }
}