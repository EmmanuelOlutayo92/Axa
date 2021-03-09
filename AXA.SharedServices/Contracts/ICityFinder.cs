using AXA.SharedServices.DataAccess;
using AXA.SharedServices.SharedImplementations;
using AXA.SharedServices.SharedImplementations.Models;
using System;
using System.Collections.Generic;
using System.Text;

//namespace name was changed from preferred "AXA.SharedServices.Contracts" to suggested namespace naming
namespace CitySearch
{
    public interface ICityFinder
    {
        
        ICityResult Search(string searchString, List<Country> countryData );

    }
}
