using System.Collections.Generic;
using System.Web.Mvc;
using FakeStateData;
using FindMyLibrary.Web.Controllers;
using FindMyLibrary.Web.Models.Domain;
using NUnit.Framework;

namespace FindMyLibrary.Controllers.UnitTests
{
    [TestFixture]
    public class CityControllerTests
    {
        [Test]
        public void GetCitiesByState_Should_Return_Json()
        {
            //Arrange
            List<City> cities = new List<City>();
            cities.Add(new City {CityId = 1, Name = "New York", StateId = 1});

            var repo = new FakeCityRepository(cities);

            var controller = new CityController(repo);

            //Act
            var result = controller.GetCitiesByState(1);

            //Assert
            Assert.IsInstanceOf<JsonResult>(result);
        }
    }
}
