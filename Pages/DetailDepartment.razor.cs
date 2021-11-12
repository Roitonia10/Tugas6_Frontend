using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFrontend_358.Models;
using BlazorFrontend_358.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorFrontend_358.Pages
{
    public partial class DetailDepartment
    {
        [Parameter]
        public string id { get; set; }
        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        public Department Department { get; set; } = new Department();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Department = await DepartmentService.GetById(int.Parse(id));
        }
    }
}