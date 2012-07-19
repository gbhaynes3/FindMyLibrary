using System.Linq;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Models.DataAccess
{
    public class CityRepository: IRepository<City>
    {
        public IQueryable<City> All { get; private set; }
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