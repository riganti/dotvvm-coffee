using DotvvmCoffeeTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotvvmCoffeeTemplate.Services
{
    public class EmployeesApi
    {
        public IQueryable<Employee> GetAll()
        {
            return new[]
            {
                new Employee(0, "Dani Michele", 20800), new Employee(1, "Elissa Malone", 18700), new Employee(2, "Raine Damian", 17300),
                new Employee(3, "Gerrard Petra", 25000), new Employee(4, "Clement Ernie", 14000, true), new Employee(5, "Rod Fred", 19300),
                new Employee(6, "Oliver Carr", 12000), new Employee(7, "Jackson James", 18000), new Employee(8, "Dexter Nicholson", 14500, true),
                new Employee(9, "Jamie Rees", 7500), new Employee(10, "Jackson Ross", 8900), new Employee(11, "Alonso Sims", 14500, true),
                new Employee(12, "Zander Britt", 45000), new Employee(13, "Isaias Ford", 9950), new Employee(14, "Braden Huffman", 100000),
                new Employee(15, "Frederick Simpson", 25000), new Employee(16, "Charlie Andrews", 14000), new Employee(17, "Reuben Byrne", 18000, true)
            }.AsQueryable();
        }
    }
}