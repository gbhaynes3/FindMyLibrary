using System.Data.Entity;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Models.DataAccess
{
    public class LibraryContext: DbContext
    {
        public DbSet<Library> Libraries { get; set; }
        public DbSet<State> States { get; set; }
    }
}