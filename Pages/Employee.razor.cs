using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LatihanBlazor.Models;

namespace LatihanBlazor.Pages
{
    public partial class EmployeePage
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();  
        }

        private void LoadEmployees()
        {
            Employee e1 = new Employee{
                EmployeeId=1,
                FirstName="Marcellus",
                LastName="Davine Setiawan",
                Email="dvinset@gmail.com",
                DateOfBirth= new DateTime(1995,01,20),
                Gender= Gender.Male,
                Department= new Department{DepartmentId=1, DepartmentName="IT"},
                PhotoPath="images/davine.jpg"
            };
             Employee e2 = new Employee{
                EmployeeId=2,
                FirstName="Yahya",
                LastName="Danianto",
                Email="yahyadani@gmail.com",
                DateOfBirth= new DateTime(1994,05,14),
                Gender= Gender.Male,
                Department= new Department{DepartmentId=2, DepartmentName="Accounting"},
                PhotoPath="images/yahya.jpg"
            };

            Employees = new List<Employee>{e1,e2};
        }
    }
}