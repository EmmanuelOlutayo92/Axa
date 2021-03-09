using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AXA.SharedServices.Contracts;
using AXA.SharedServices.DataAccess;
using AXA.SharedServices.SharedImplementations.Models;
using CitySearch;
using Microsoft.AspNetCore.Mvc;

namespace AxaMessageBroker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityFinderController : Controller
    {
        private readonly ICityFinder _cityFinder;
        private ICountryData _countryData;
        private CountryContext _db; 


        public CityFinderController(ICityFinder CityFinder, ICountryData countryData)
        {
            _cityFinder = CityFinder;
            _countryData = countryData;  
        }

        private void LoadSampleData()
        {
            if(_db.Countries.Count() == 0)
            {
                string file = System.IO.File.ReadAllText("generated.json");
                var countries = JsonSerializer.Deserialize<List<Country>>(file);
                _db.AddRange(countries);
                _db.SaveChanges(); 
            }
        }

        [HttpGet]
        public IActionResult Index([FromQuery] string SearchTerm)
        {
            var data = _countryData.GetCountryList();
           // LoadSampleData();
            var result = _cityFinder.Search(SearchTerm, data);
            
            return Ok(result);
        }
    }
}
