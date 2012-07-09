using System.Collections.Generic;
using System.Web.Mvc;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          return View();
        }

    }
}
