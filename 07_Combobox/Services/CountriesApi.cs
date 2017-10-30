using DotvvmCoffeeTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotvvmCoffeeTemplate.Services
{
    public class CountriesApi
    {
        public List<Country> GetAll()
        {
            return new List<Country>()
            {
                new Country()
                {
                    Id = 0,
                    Name = "Czech Republic"
                },
                new Country()
                {
                    Id = 1,
                    Name = "Slovakia"
                }
            };
        }

        public List<string> GetCities(int? countryId)
        {
            switch (countryId)
            {
                case 0:
                    return new List<string>() { "Praha", "Brno", "Ostrava" };
                case 1:
                    return new List<string>() { "Bratislava", "Košice" };
                default:
                    return new List<string>();
            }
        }
    }
}