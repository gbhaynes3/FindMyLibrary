using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Web;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Models.DataAccess
{
  public class LibraryRepository: ILibraryRepository
  {

      
    LibraryContext context = new LibraryContext();

    public IQueryable<Library> All { get { return context.Libraries; } }
      public Library Find(int id)
      {
          throw new NotImplementedException();
      }

      public void InsertOrUpdate(Library entity)
      {
          throw new NotImplementedException();
      }

      public void Delete(int id)
      {
          throw new NotImplementedException();
      }

      public void Save()
      {
          throw new NotImplementedException();
      }

      public IQueryable<Library> FindByLocation(float latitude, float longitude)
      {
          throw new NotImplementedException();
      }

      public IQueryable<Library> FindLibrariesByText(string q)
      {
          throw new NotImplementedException();
      }

    public Library FindByName(string stateAbbreviaiton, string cityName, string name)
    {
      return
        context.Libraries.FirstOrDefault(l => l.Address.State.Abbreviation.Equals(stateAbbreviaiton) && l.Address.City.Equals(cityName) && l.Name.Equals(name));
    }

    public IQueryable<RouteLibrary> FindByCityState(string stateAbbreviaiton, string cityName)
      {
        return
          from l in context.Libraries
          join a in context.Addresses on l.Address.AddressId equals a.AddressId
          join s in context.States on a.State.Id equals s.Id
          select new RouteLibrary { Name = l.Name, CityName = a.City, StateAbbreviation = s.Abbreviation };
      }
  }
}