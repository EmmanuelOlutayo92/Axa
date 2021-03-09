using System;
using System.Collections.Generic;
using System.Text;


//namespace name was changed from preferred "AXA.SharedServices.Contracts" to suggested namespace naming
namespace CitySearch
{
    public interface ICityResult
    {
        ICollection<string> NextLetters { get; set; }

        ICollection<string> NextCities { get; set; }
    }
}
