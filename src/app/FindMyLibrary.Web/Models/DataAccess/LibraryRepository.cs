using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Models.DataAccess
{
  public class LibraryRepository: ILibraryRepository
  {
      public IQueryable<Library> All { get; private set; }
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
  }
}