using System.Collections.Generic;
using System.Linq;
using FindMyLibrary.Web.Models.DataAccess;
using FindMyLibrary.Web.Models.Domain;

namespace FakeStateData
{
    public class FakeCityRepository: IRepository<City>
    {
        private readonly List<City> cities;

        public FakeCityRepository(List<City> cities )
        {
            this.cities = cities;
        }

        public IQueryable<City> All { get { return cities.AsQueryable(); } }

        public City Find(int id)
        {
            throw new System.NotImplementedException();
        }

        public void InsertOrUpdate(City entity)
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
