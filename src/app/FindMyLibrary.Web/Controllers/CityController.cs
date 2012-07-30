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

        private IRepository<City> repository;

        public CityController() :this(new CityRepository())
        {
        }

        public CityController(IRepository<City> repository )
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            return View();
        }

      
        public ActionResult GetCitiesByState(string stateAbbreviaiton)
        {
          var cities = repository.All.Where(x => x.StateAbbreviation.Equals(stateAbbreviaiton));

            var jsonCities = from city in cities.AsEnumerable()
                             select JsonCityFromCity(city);

            return Json(jsonCities.ToList());
        }

        private JsonCity JsonCityFromCity(City city)
        {
            return new JsonCity
                {
                    CityId = city.CityId,
                    Name = city.Name,
                    Url = city.Name
                };
        }
    }

    
}
