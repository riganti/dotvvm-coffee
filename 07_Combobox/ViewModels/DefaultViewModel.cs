using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotVVM.Framework.ViewModel;
using DotvvmCoffeeTemplate.Models;
using DotvvmCoffeeTemplate.Services;
using System.Threading.Tasks;

namespace DotvvmCoffeeTemplate.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
        private readonly CountriesApi countriesApi = new CountriesApi();

        public List<Country> Countries { get; set; } = new List<Country>();
        public List<string> Cities { get; set; } = new List<string>();

        public Country SelectedCountry { get; set; }
        public string SelectedCity { get; set; }

        public override Task Load()
        {
            Countries = countriesApi.GetAll();

            return base.Load();
        }

        public void SelectedCountryChanged()
        {
            Cities = countriesApi.GetCities(SelectedCountry?.Id);
            SelectedCity = null;
        }
    }
}

