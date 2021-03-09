using AXA.SharedServices.SharedImplementations.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AXA.SharedServices.Contracts
{
    public interface ICountryData
    {
        public List<Country> GetCountryList(); 
    }
}
