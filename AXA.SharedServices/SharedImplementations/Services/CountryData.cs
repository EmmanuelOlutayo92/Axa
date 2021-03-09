using AXA.SharedServices.Contracts;
using AXA.SharedServices.DataAccess;
using AXA.SharedServices.SharedImplementations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AXA.SharedServices.SharedImplementations
{
    public class CountryData : ICountryData
    {
        private readonly  CountryContext _countryContext;


        public CountryData(CountryContext countryContext)
        {
            _countryContext = countryContext; 
        }
      
        public List<Country> GetCountryList()
        {
            var countryList = _countryContext.Countries.ToList();

            return countryList; 
        }
    }
}
