namespace FindMyLibrary.Loader
{
  class Program
  {
    static FindMyLibraryEntities db = new FindMyLibraryEntities();

    static void Main(string[] args)
    {
      var file = new LinqToExcel.ExcelQueryFactory(@"C:\public_libraries.csv");
      file.AddMapping<FlatLibrary>(x => x.Name, "Location Name");

      ClearAddresses();

      AddAddressesToDataStore(file);

      AddLibrariesToDataStore(file);


      Console.ReadLine();
    }

    private static void ClearAddresses()
    {
      db.ExecuteStoreCommand("DELETE FROM dbo.Addresses");
      db.ExecuteStoreCommand("DBCC CHECKIDENT (Addresses, RESEED, 0)");
    }

    private static void AddLibrariesToDataStore(ExcelQueryFactory file)
    {
      var allLibraries = from f in file.Worksheet<FlatLibrary>()
                         select FlatLibraryToLibrary(f);

      var libraryList = allLibraries.ToList().Distinct();

      Console.WriteLine(allLibraries.Count());
    }

    private static void AddAddressesToDataStore(ExcelQueryFactory file)
    {
      var allLibraries = from f in file.Worksheet<FlatLibrary>()
                         select FlatLibraryToLibrary(f);

      var libraryList = allLibraries.ToList();

      var addresses = (libraryList.Select(a => a.Address)).Distinct(new AddressComparer());



      foreach (var address in addresses)
      {
        db.Addresses.AddObject(address);

        db.SaveChanges();
      }


      Console.WriteLine("Added new libraries");
    }

    private static int FindStateByAbberviation(string abbreviation)
    {
      var state = db.States.FirstOrDefault(s => s.Abbreviation.Equals(abbreviation));

      return state.Id;
    }

    private static Library FlatLibraryToLibrary(FlatLibrary flatLibrary)
    {
      return new Library
      {
        Name = flatLibrary.Name,
        Address = new Address
        {
          City = flatLibrary.City,
          Line1 = flatLibrary.Address,
          Zip = flatLibrary.Zip,
          State_Id = FindStateByAbberviation(flatLibrary.State)
        }
      };
    }

  }

  public class FlatLibrary
  {
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
  }
}
