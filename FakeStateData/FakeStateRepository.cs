using System.Collections.Generic;
using System.Linq;
using FindMyLibrary.Web.Models.DataAccess;
using FindMyLibrary.Web.Models.Domain;

namespace FakeStateData
{
    public class FakeStateRepository: IRepository<State>
    {
        private readonly List<State> stateList;

        public FakeStateRepository(List<State> states)
        {
            stateList = states;
        }

        public IQueryable<State> All { get { return stateList.AsQueryable(); } }

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
