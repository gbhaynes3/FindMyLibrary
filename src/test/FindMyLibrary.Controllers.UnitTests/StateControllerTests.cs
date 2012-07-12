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
    public void GetStates_Should_Return_A_List_Of_States()
    {
        var repository = new StateRepository();
        repository.CreateStates();
        var controller = new StateController(repository);

        var result = (JsonResult) controller.GetStates();
        var list = result.Data;

        Assert.IsNotNullOrEmpty(list.ToString());
    }
  }
}
