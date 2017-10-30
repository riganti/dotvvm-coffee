using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotVVM.Framework.ViewModel;

namespace DotvvmCoffeeTemplate.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public double Result { get; set; }

        public void Calculate(int precision)
        {
            Result = Math.Round(Number1 + Number2, precision);
        }
    }
}

