using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FindMyLibrary.Domain;

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
