using System;
using System.Activities.Statements;
using System.Web.Mvc;
using FindMyLibrary.Web.Models.DataAccess;

namespace FindMyLibrary.Web.Controllers
{
    public class StateController : Controller
    {

      private StateRepository repo;

      public StateController() : this(new StateRepository())
      {
      }

      public StateController(StateRepository repository)
      {
        repo = repository;
      }
        public ActionResult GetStates()
        {
          throw new NotImplementedException();
        }

    }
}
