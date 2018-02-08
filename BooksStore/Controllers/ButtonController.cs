using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BooksStore.Controllers
{
    [RoutePrefix("button")]
    public class ButtonController : Controller
    {
        public ActionResult Index(int obj)
        {
            return View();
        }
    }
}