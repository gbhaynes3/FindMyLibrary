using System.Collections.Generic;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Tests.Fakes
{
  public class FakeLibraryData
    {
      public static List<Library> CreateTestLibraries()
      {
        List<Library> libraries = new List<Library>();

        for (int i = 0; i<101; i++)
        {
          Library sampleLibrary = new Library()
                                    {
                                      Id = i,
                                      Name = "Sample Library",
                                      Phone = "555-555-5555",
                                      Address = new Address()
                                                  {
                                                    City = "Sample City",
                                                    Line1 = "123 Main Street",
                                                    State = new State()
                                                              {
                                                                Id = "AL",
                                                                Name = "Alabama"
                                                              },
                                                    Zip = "55555"
                                                  }
                                    };
          libraries.Add(sampleLibrary);
        }

        return libraries;
      }
    }
}
