using System;
using System.Collections.Generic;
using System.Text;

namespace AXA.SharedServices.Contracts
{
    public interface ICountries
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
    }
}
