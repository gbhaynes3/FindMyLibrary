using System.Collections.Generic;
using System.Web.Mvc;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Controllers
{
    public class HomeController : Controller
    {
      private List<State> states;

        public HomeController(List<State> states)
        {
          this.states = states;
        }
        public ActionResult Index()
        {
            return View(states);
        }

    }
}
