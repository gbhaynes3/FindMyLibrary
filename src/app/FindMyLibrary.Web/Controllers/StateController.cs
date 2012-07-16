using System;
using System.Activities.Statements;
using System.Linq;
using System.Web.Mvc;
using FindMyLibrary.Web.Models.DataAccess;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Controllers
{
    public class JsonState
    {
        public string StateId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class StateController : Controller
    {

        private StateRepository repo;

        public StateController() : this(new StateRepository())
        {
        }

        public StateController(StateRepository repository)
        {
            repo = repository;
            repo.CreateStates();
        }
        
        public ActionResult GetStates()
        {
            var states = repo.FindAllStates();

            var jsonStates = from state in states.AsEnumerable()
                             select JsonStateFromState(state);

            return Json(jsonStates.ToList());
        }

        private JsonState JsonStateFromState(State state)
        {
            return new JsonState
                {
                    StateId = state.Id,
                    Name = state.Name,
                    Url = state.Id
                };
        }

    }
}
