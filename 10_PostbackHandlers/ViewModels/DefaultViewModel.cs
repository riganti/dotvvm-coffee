using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotVVM.Framework.ViewModel;

namespace DotvvmCoffeeTemplate.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
        public string Name { get; set; }
        public List<string> Fruits { get; set; } = new List<string>()
        {
            "Apple", "Banana", "Orange"
        };

        public void AddFruit(string name) => Fruits.Add(name);
    }
}

