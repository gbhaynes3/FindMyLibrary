using System;
using FindMyLibrary.Domain;

namespace FindMyLibrary.Web.Models.Domain
{
    public class Library
    {
      public int Id { get; set; }
      public string Name { get; set; }
      public Address Address { get; set; }
      public string Phone { get; set; }
      public Location Location { get; set; }
    }
}
