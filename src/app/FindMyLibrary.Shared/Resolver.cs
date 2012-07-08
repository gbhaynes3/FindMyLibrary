using StructureMap;

namespace FindMyLibrary.Shared
{
  public static class Resolver
  {
    public static T GetConcreteInstanceOf<T>()
    {
      return ObjectFactory.GetInstance<T>();
    }
  }
}
