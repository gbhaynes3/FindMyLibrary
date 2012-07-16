using System.Data.Entity;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Models.DataAccess
{
    public class LibraryContext: DbContext
    {

        public LibraryContext() : base("FindMyLibrary")
        {
        }

        public DbSet<Library> Libraries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}