using System.Collections.Generic;
using System.Web.Mvc;
using FakeStateData;
using FindMyLibrary.Web.Controllers;
using FindMyLibrary.Web.Models.DataAccess;
using FindMyLibrary.Web.Models.Domain;
using NUnit.Framework;

namespace FindMyLibrary.Controllers.UnitTests
{
    [TestFixture]
    public class StateControllerTests
    {
        [Test]
        public void GetStates_Should_Return_All_States()
        {
            //Arragne
            List<State> states = new List<State>();
            states.Add(new State { Abbreviation = "AL", Id = 1, Name = "Alabama"});
            states.Add(new State { Abbreviation = "CA", Id = 2, Name = "California" });
            states.Add(new State { Abbreviation = "NY", Id = 3, Name = "New York" });

            var repo = new FakeStateRepository(states);

            var controller = new StateController(repo);

            //Act
            var result = controller.GetStates();

            //Assert
            
        }

        [Test]
        public void GetStates_Should_Return_Json()
        {
            //Arragne
            List<State> states = new List<State>();
            states.Add(new State { Abbreviation = "AL", Id = 1, Name = "Alabama" });
            states.Add(new State { Abbreviation = "CA", Id = 2, Name = "California" });
            states.Add(new State { Abbreviation = "NY", Id = 3, Name = "New York" });

            var repo = new FakeStateRepository(states);

            var controller = new StateController(repo);

            ActionResult result = controller.GetStates();

            Assert.IsInstanceOf<JsonResult>(result);
        }

        [Test]
        public void GetStates_Should_Return_JsonStates()
        {
            List<State> states = new List<State>();
            states.Add(new State { Abbreviation = "AL", Id = 1, Name = "Alabama" });
            states.Add(new State { Abbreviation = "CA", Id = 2, Name = "California" });
            states.Add(new State { Abbreviation = "NY", Id = 3, Name = "New York" });

            var repo = new FakeStateRepository(states);

            var controller = new StateController(repo);

            var result = (JsonResult) controller.GetStates();

            Assert.IsInstanceOf<List<JsonState>>(result.Data);
        }
    }
}