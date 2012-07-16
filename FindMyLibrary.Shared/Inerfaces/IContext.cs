using System.Data.Objects;
using FindMyLibrary.Model;

namespace FindMyLibrary.Shared.Inerfaces
{
    public interface IContext
    {
        IObjectSet<State> States { get; }

    }
}
