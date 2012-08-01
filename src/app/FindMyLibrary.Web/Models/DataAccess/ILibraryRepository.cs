using System.Linq;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Models.DataAccess
{
  public interface ILibraryRepository: IRepository<Library>
  {
    IQueryable<Library> FindByLocation(float latitude, float longitude);
    IQueryable<Library> FindLibrariesByText(string q);
    IQueryable<Library> FindByCityState(string stateAbbreviaiton, string cityName);
  }
}
