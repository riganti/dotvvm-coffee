using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotVVM.Framework.Controls;
using DotVVM.Framework.Binding;

namespace DotvvmCoffeeTemplate.Controls
{
    public class YesNoQuestion : DotvvmMarkupControl
    {
        public string Question
        {
            get { return (string)GetValue(QuestionProperty); }
            set { SetValue(QuestionProperty, value); }
        }
        public static readonly DotvvmProperty QuestionProperty
            = DotvvmProperty.Register<string, YesNoQuestion>(c => c.Question, null);


        public bool IsYes
        {
            get { return (bool)GetValue(IsYesProperty); }
            set { SetValue(IsYesProperty, value); }
        }
        public static readonly DotvvmProperty IsYesProperty
            = DotvvmProperty.Register<bool, YesNoQuestion>(c => c.IsYes, false);

    }
}

