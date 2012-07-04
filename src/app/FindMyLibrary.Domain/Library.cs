using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyLibrary.Domain
{
    public class Library
    {
      public Guid Id { get; set; }
      public string Name { get; set; }
      public Address Address { get; set; }
      public string Phone { get; set; }
      public Location Location { get; set; }
    }
}
