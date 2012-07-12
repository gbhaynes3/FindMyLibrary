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
    public void GetStates_Should_Return_A_List_Of_States()
    {

      var repository = new StateRepository();
      
      var controller = new StateController(repository);

      var result = (ViewResult) controller.GetStates();
      List<State> list = result.ViewData.Model as List<State>;

      Assert.AreEqual(50, list.Count);
    }
  }
}
