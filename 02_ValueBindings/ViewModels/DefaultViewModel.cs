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
        public bool SayHello { get; set; }
    }
}

