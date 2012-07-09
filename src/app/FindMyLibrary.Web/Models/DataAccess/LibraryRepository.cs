using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Models.DataAccess
{
  public class LibraryRepository: ILibraryRepository
  {
    public IQueryable<Library> FindAllLibraries()
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

    public Library GetLibrary(int id)
    {
      throw new NotImplementedException();
    }

    public void Add(Library library)
    {
      throw new NotImplementedException();
    }

    public void Delete(Library library)
    {
      throw new NotImplementedException();
    }

    public void Save()
    {
      throw new NotImplementedException();
    }
  }
}