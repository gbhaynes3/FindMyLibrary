using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using FindMyLibrary.Domain;
using FindMyLibrary.Web.Controllers;
using FindMyLibrary.Web.Models.Domain;
using NUnit.Framework;

namespace FindMyLibrary.Controllers.UnitTests
{
  [TestFixture]
  public class HomeControllerTests
  {
    [Test]
    public void Index_Should_Return_List_Of_States()
    {
      List<State> states = new List<State>
                             {
                               new State{Id = "AL", Name = "Alabama"},
                               new State{Id="FL", Name = "Florida"},
                               new State{Id="GA", Name = "Georgia"},
                               new State{Id="TN", Name = "Tennessee"},
                               new State{Id="CA", Name = "California"}
                             };
      var homeController = new HomeController(states);

      var result = homeController.Index() as ViewResult;
      List<State> resultList = result.Model as List<State>;

      Assert.AreEqual(5, resultList.Count);
    }
  }
}
