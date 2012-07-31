using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindMyLibrary.Loader
{
  class AddressComparer : IEqualityComparer<Address>
  {
    public bool Equals(Address x, Address y)
    {
      if (Object.ReferenceEquals(x, y)) return true;

      if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
        return false;

      return x.Line1 == y.Line1 && x.City == y.City && x.State_Id == y.State_Id;
    }

    public int GetHashCode(Address obj)
    {
      if (Object.ReferenceEquals(obj, null)) return 0;

      int hashAddressLine1 = obj.Line1 == null ? 0 : obj.Line1.GetHashCode();

      int hashCity = obj.City == null ? 0 : obj.City.GetHashCode();

      return hashAddressLine1 ^ hashCity;
    }
  }
}
