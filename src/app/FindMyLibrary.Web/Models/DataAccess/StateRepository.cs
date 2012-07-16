using System.Collections.Generic;
using System.Linq;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Models.DataAccess
{
  public class StateRepository: IRepository<State>
  {
    private List<State> states = new List<State>();

      LibraryContext context = new LibraryContext();

      public IQueryable<State> All { get { return context.States; } }

      public State Find(int id)
      {
          throw new System.NotImplementedException();
      }

      public void InsertOrUpdate(State entity)
      {
          throw new System.NotImplementedException();
      }

      public void Delete(int id)
      {
          throw new System.NotImplementedException();
      }

      public void Save()
      {
          throw new System.NotImplementedException();
      }
  }
}