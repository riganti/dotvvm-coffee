using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Controls;

namespace DotvvmCoffeeTemplate.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
        public UploadedFilesCollection UploadedFiles { get; set; } = new UploadedFilesCollection();
    }
}

