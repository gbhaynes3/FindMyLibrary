using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FindMyLibrary.Web.Helpers;
using FindMyLibrary.Web.Models.DataAccess;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Controllers
{
    public class LibraryController : Controller
    {
      private ILibraryRepository libraryRepository;

      public LibraryController(): this(new LibraryRepository()){}

      public LibraryController(ILibraryRepository repository)
      {
        libraryRepository = repository;
      }

        public ActionResult Index(string q, int? page)
        {
          const int pageSize = 25;

          IQueryable<Library> libraries = null;

          if (!string.IsNullOrEmpty(q))
            libraries = libraryRepository.FindLibrariesByText(q);
          else
            libraries = libraryRepository.FindAllLibraries();

          var paginatedLibraries = new PaginatedList<Library>(libraries, page ?? 0, pageSize);
          
          return View(paginatedLibraries);
        }

    }
}
