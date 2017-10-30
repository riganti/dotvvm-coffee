using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotVVM.Framework.ViewModel;
using System.Drawing;

namespace DotvvmCoffeeTemplate.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
        public List<Color> Colors { get; set; } = new List<Color>()
        {
            Color.Crimson,
            Color.Tomato,
            Color.Gold,
            Color.YellowGreen,
            Color.SkyBlue
        };
    }
}

