﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FindMyLibrary.Web.Models.DataAccess;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Tests.Fakes
{
  public class FakeLibraryRepository: ILibraryRepository
  {
    private List<Library> libraryList;

    public FakeLibraryRepository(List<Library> libraries )
    {
      libraryList = libraries;
    }
    public IQueryable<Library> FindAllLibraries()
    {
      return libraryList.AsQueryable();
    }

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