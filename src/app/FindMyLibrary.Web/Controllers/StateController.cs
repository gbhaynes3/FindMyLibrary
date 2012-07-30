using System;
using System.Activities.Statements;
using System.Linq;
using System.Web.Mvc;
using AttributeRouting.Web.Mvc;
using FindMyLibrary.Web.Models.DataAccess;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Controllers
{
    public class JsonState
    {
        public int StateId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class StateController : Controller
    {

        private IRepository<State> repo;

        public StateController() : this(new StateRepository())
        {
        }

        public StateController(IRepository<State> repository)
        {
            repo = repository;
            
        }
        
        
        public ActionResult GetStates()
        {
            var states = repo.All;

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
                    Url = "/City/" + state.Id.ToString()
                };
        }

    }
}
