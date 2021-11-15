using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFrontend_358.Models;

namespace BlazorFrontend_358.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> GetById(int id);
        Task<Employee> Add(Employee employee);
        Task<Employee> Update(int id, Employee employee);
        Task Delete(int id);

    }
}
