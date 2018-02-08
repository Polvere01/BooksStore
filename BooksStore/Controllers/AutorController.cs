using BooksStore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BooksStore.Controllers
{
    public class AutorController : Controller
    {
        private IAuthorizationFilter repository;

        public AutorController()
        {
            repository = new AutorRepository();
        }
    }
}