using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Controls;
using DotvvmCoffeeTemplate.Models;
using DotvvmCoffeeTemplate.Services;

namespace DotvvmCoffeeTemplate.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
        private readonly EmployeesApi employeesApi = new EmployeesApi();

        public GridViewDataSet<Employee> Employees { get; set; }

        private GridViewDataSetLoadedData<Employee> GetData(IGridViewDataSetLoadOptions gridViewDataSetLoadOptions)
        {
            return employeesApi.GetAll().GetDataFromQueryable(gridViewDataSetLoadOptions);
        }

        public override Task Init()
        {
            Employees = GridViewDataSet.Create(gridViewDataSetLoadDelegate: GetData, pageSize: 4);

            return base.Init();
        }
    }
}

