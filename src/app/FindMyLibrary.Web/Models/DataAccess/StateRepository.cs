using System.Collections.Generic;
using System.Linq;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Models.DataAccess
{
  public class StateRepository
  {
    private List<State> states = new List<State>();

    public void CreateStates()
    {
        states.Add(new State(){Id = "AL", Name = "Alabama"});
    }

    public IQueryable<State> FindAllStates()
    {
      return states.AsQueryable();
    }
  }
}