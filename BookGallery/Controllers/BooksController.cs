using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookGallery.Controllers
{
    public class BooksController : Controller
    {
        // Action result almost always used for action method regardless of return type
        public ActionResult Detail()
        {
            return View();
        }
    }
}