using AXA.GenericImplementation.ServiceEntities;
using AXA.SharedServices.DataAccess;
using AXA.SharedServices.SharedImplementations;
using AXA.SharedServices.SharedImplementations.Models;
using CitySearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AXA.GenericImplementation.Services
{
    public class CityFinder : ICityFinder
    {

        //Data source list of Cities
        //so specification was provided on an implementation for datasource o a list of all cities provided was used
        List<string> cityDataSource = new List<string> { "BANDUNG", "BANGUI", "BANGKOK", "BANGALORE", "LA PAZ", "LA PLATA", "LAGOS", "LEEDS", "ZARIA", "ZHUGHAI", "ZIBO" };
        

        public List<string> DataList( List<Country> data)
        {
            return  data?.Select(x => x.CountryName).ToList() ?? new List<string>(); 
        }

        /// <summary>
        /// This method given an input string, searches through a list of cities and provices a list of search results (cities) and the next characters of the search results 
        /// </summary>
        /// <param name="searchString">The keyword/character for searching through the list of cities</param>
        /// <returns></returns>
        public ICityResult Search(string searchString, List<Country> data)
        {
            CityResult cityResult;

            //Get the count of the input string
            int searcharCount = searchString.Length;

            List<string> nextLetters = new List<string>();

            var citiesSearchResult = DataList(data).Where(x => x.StartsWith(searchString,StringComparison.InvariantCultureIgnoreCase));

            

            foreach (var city in citiesSearchResult)
            {
                //set the index for the next element which will be equal to the count since array is Zero indexed
                int index = searcharCount;

                //Set next character
                string nextCharacter = city.ElementAt(index).ToString();

                //check if the element already exist and skip if the conditions are met
                if (nextLetters.Contains(nextCharacter))
                    continue;

                //Add the element at the index to the list of next letters
                nextLetters.Add(nextCharacter);
            }

            //return CityResult concrete type
            cityResult = new CityResult
            {
                NextCities = citiesSearchResult.ToList(),
                NextLetters = nextLetters
            };

            return cityResult;
        }
    }
}
