using System.Collections.Generic;
using System.Linq;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Models.DataAccess
{
    public class AddressRepository: IRepository<Address>
    {
      private List<Address> addresses = new List<Address>();

        LibraryContext context = new LibraryContext();

        public IQueryable<Address> All { get { return context.Addresses; } }

      public Address Find(int id)
        {
            throw new System.NotImplementedException();
        }

      public void InsertOrUpdate(Address entity)
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