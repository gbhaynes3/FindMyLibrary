using System;
using System.Collections.Generic;
using System.Linq;
using FindMyLibrary.Web.Models.DataAccess;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Tests.Fakes
{
    public class FakeLibraryRepository : ILibraryRepository
    {
        private readonly List<Library> libraryList;

        public FakeLibraryRepository(List<Library> libraries)
        {
            libraryList = libraries;
        }

        #region ILibraryRepository Members

        public IQueryable<Library> All { get { return libraryList.AsQueryable(); } }

        public IQueryable<Library> FindByLocation(float latitude, float longitude)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Library> FindLibrariesByText(string q)
        {
            return libraryList.AsQueryable().Where(l => l.Name.Contains(q)
                                                        || l.Address.Line1.Contains(q)
                                                        || l.Address.City.Contains(q));
        }

      public Library FindByName(string stateAbbreviaiton, string cityName, string name)
      {
        throw new NotImplementedException();
      }

      public IQueryable<RouteLibrary> FindByCityState(string stateAbbreviaiton, string cityName)
      {
        throw new NotImplementedException();
      }


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

        #endregion
    }
}