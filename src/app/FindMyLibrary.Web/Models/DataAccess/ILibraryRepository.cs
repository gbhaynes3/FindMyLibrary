using System.Linq;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Models.DataAccess
{
  public interface ILibraryRepository
  {
    IQueryable<Library> FindAllLibraries();
    IQueryable<Library> FindByLocation(float latitude, float longitude);
    IQueryable<Library> FindLibrariesByText(string q);

    Library GetLibrary(int id);

    void Add(Library library);
    void Delete(Library library);

    void Save();
  }
}
