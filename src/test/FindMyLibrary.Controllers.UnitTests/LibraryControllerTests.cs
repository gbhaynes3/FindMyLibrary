using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using FindMyLibrary.Tests.Fakes;
using FindMyLibrary.Web.Controllers;
using FindMyLibrary.Web.Helpers;
using FindMyLibrary.Web.Models.Domain;
using Moq;
using NUnit.Framework;

namespace FindMyLibrary.Tests.Controllers.UnitTests
{
  [TestFixture]  
  public class LibraryControllerTests
  {
    LibraryController CreateLibraryController()
    {
      var testData = FakeLibraryData.CreateTestLibraries();
      var repository = new FakeLibraryRepository(testData);

      return new LibraryController(repository);  
    }

    LibraryController CreateLibraryControllerAs(string userName)
    {
      var mock = new Mock<ControllerContext>();
      mock.SetupGet(p => p.HttpContext.User.Identity.Name).Returns(userName);
      mock.SetupGet(p => p.HttpContext.Request.IsAuthenticated).Returns(true);

      var controller = CreateLibraryController();
      controller.ControllerContext = mock.Object;

      return controller;
    }

    [Test]
    public void Index_Should_Return_View()
    {
      //Arrange
      var controller = CreateLibraryControllerAs("bob");

      //Act
      var result = (ViewResult)controller.Index(string.Empty, 0);
      
      //Assert
      Assert.IsInstanceOf<ViewResult>(result);
    }

    [Test]
    public void Index_Should_Return_View_Of_List_Libraries()
    {
      //Arrange
      var controller = CreateLibraryControllerAs("bob");

      //Act
      var result = (ViewResult)controller.Index(null, 0);

      //Assert
      Assert.IsInstanceOf<IList<Library>>(result.ViewData.Model);
    }

    [Test]
    public void Index_Should_Return_PagedList()
    {
      var controller = CreateLibraryControllerAs("bob");

      var result = (ViewResult) controller.Index(null, 0);

      Assert.IsInstanceOf<PaginatedList<Library>>(result.ViewData.Model);
    }

    [Test]
    public void Index_Should_Return_PagedList_With_Total_of_101_And_Total_10_Pages()
    {
      var controller = CreateLibraryControllerAs("bob");

      var result = (ViewResult) controller.Index(null, 0);
      var list = result.ViewData.Model as PaginatedList<Library>;

      Assert.AreEqual(101, list.TotalCount);
      Assert.AreEqual(5, list.TotalPages);
    }

    [Test]
    public void Index_With_Library_Just_Return_Library_By_Id()
    {
      var testData = FakeLibraryData.CreateTestLibraries();
      var library = FakeLibraryData.CreateLibrary();
      library.Id = -1;
      library.Name = "New City Main";
      testData.Add(library);

      var repository = new FakeLibraryRepository(testData);

      var controller = new LibraryController(repository);

      ViewResult result = (ViewResult) controller.Index(null, null);
      PaginatedList<Library> list = result.ViewData.Model as PaginatedList<Library>;

      Assert.AreEqual("New City Main", list.First().Name);
    }
  }
}
