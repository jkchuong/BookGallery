using BookGallery.Data;
using BookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookGallery.Controllers
{
    public class BooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public BooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        // Action result almost always used for action method regardless of return type
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook(id.Value);
            
            // strongly typed view
            return View(comicBook);
        }
    }
}