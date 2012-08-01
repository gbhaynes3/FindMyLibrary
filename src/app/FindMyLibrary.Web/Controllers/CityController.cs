using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributeRouting.Web.Mvc;
using FindMyLibrary.Web.Models.DataAccess;
using FindMyLibrary.Web.Models.Domain;

namespace FindMyLibrary.Web.Controllers
{
    public class JsonCity
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
    
    public class CityController : Controller
    {

        private IRepository<Address> repository;

        public CityController() :this(new AddressRepository())
        {
        }

        public CityController(IRepository<Address> repository )
        {
            this.repository = repository;
        }

        public ActionResult Index(string stateAbbreviation)
        {
          var cities = repository.All.Where(x => x.State.Abbreviation.Equals(stateAbbreviation)).Select(a => new City { Name = a.City });

          var jsonCities = from city in cities.AsEnumerable()
                           select JsonCityFromCity(city);

          return Json(jsonCities.ToList());
        }


        public ActionResult GetCitiesByState(string stateAbbreviation)
        {
          var cities = repository.All.Where(x => x.State.Abbreviation.Equals(stateAbbreviation)).Select(a => new City { Name = a.City, stateAbbreviation = stateAbbreviation });

          return View(cities);
        }

        private JsonCity JsonCityFromCity(City city)
        {
            return new JsonCity
                {
                    Name = city.Name,
                    Url = city.Name
                };
        }
    }

    
}
