using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotvvmCoffeeTemplate.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture => $"/Resources/Images/ProfilePictures/{Id}.svg";
        public double Salary { get; set; }
        public bool IsFormer { get; set; }

        public Employee() { }
        public Employee(int id, string name, double salary, bool isFormer = false)
        {
            Id = id;
            Name = name;
            Salary = salary;
            IsFormer = isFormer;
        }
    }
}