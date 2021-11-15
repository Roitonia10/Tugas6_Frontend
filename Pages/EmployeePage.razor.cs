using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFrontend_358.Models;
using BlazorFrontend_358.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorFrontend_358.Pages
{
    public partial class EmployeePage
    {
        public IEnumerable<Employee> Employees { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetAll()).ToList();
        }
    }
}