using System.Collections.Generic;
using System.Linq;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Models.DataAccess
{
  public class StateRepository
  {
    private List<State> states = new List<State>();

    public void CreateStates()
    {
        states.Add(new State {Id = "AL", Name = "Alabama"});
        states.Add(new State { Id = "AK", Name = "Alaska" });
        states.Add(new State{Id="AZ", Name = "Arizona"});
        states.Add(new State{Id="AR", Name="Arkansas"});
        states.Add(new State{Id="CA", Name="California"});
        states.Add(new State{Id="CO", Name="Colorado"});
        states.Add(new State{Id="CT", Name="Connecticut"});
        states.Add(new State{Id="DE", Name="Delaware"});
        states.Add(new State{Id="FL", Name="Florida"});
        states.Add(new State{Id="GA", Name="Georgia"});
        states.Add(new State{Id="HI", Name="Hawaii"});
        states.Add(new State{Id = "ID", Name = "Idaho" });
        states.Add(new State{Id="IL", Name="Illinois"});
        states.Add(new State{Id="IN", Name="Indiana"});
        states.Add(new State{Id="IA", Name="Iowa"});
        states.Add(new State{Id="KA", Name="Kansas"});
        states.Add(new State{Id="KY", Name="Kentucky"});
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" }); 
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
        states.Add(new State { Id = "KY", Name = "Kentucky" });
    }

    public IQueryable<State> FindAllStates()
    {
      return states.AsQueryable();
    }
  }
}