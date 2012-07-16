using System.Collections.Generic;
using System.Web.Mvc;
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
        public void GetStates_Should_Return_50_States()
        {
            var repository = new StateRepository();
            repository.CreateStates();
            var controller = new StateController(repository);

            var result = (JsonResult) controller.GetStates();

            var states = (List<JsonState>) result.Data;
            Assert.AreEqual(50, states.Count);
        }

        [Test]
        public void GetStates_Should_Return_Json()
        {
            var repository = new StateRepository();
            repository.CreateStates();
            var controller = new StateController(repository);

            ActionResult result = controller.GetStates();

            Assert.IsInstanceOf<JsonResult>(result);
        }

        [Test]
        public void GetStates_Should_Return_JsonStates()
        {
            var repository = new StateRepository();
            repository.CreateStates();
            var controller = new StateController(repository);

            var result = (JsonResult) controller.GetStates();

            Assert.IsInstanceOf<List<JsonState>>(result.Data);
        }
    }
}