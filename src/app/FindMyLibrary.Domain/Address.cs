using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyLibrary.Domain
{
  public class Address
  {
    public string Line1 { get; set; }
    public string City { get; set; }
    public State State { get; set; }
    public string Zip { get; set; }

  }
}
