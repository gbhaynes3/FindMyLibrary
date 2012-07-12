using System.Collections.Generic;
using System.Linq;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Models.DataAccess
{
  public class StateRepository
  {
    private IList<State> states;



    public IQueryable<State> FindAllStates()
    {
      return states.AsQueryable();
    }
  }
}