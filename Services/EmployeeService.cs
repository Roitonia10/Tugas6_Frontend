using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using BlazorFrontend_358.Models;
using System.Text.Json;

namespace BlazorFrontend_358.Services
{
    public class EmployeeService : IEmployeeService
    {
        private HttpClient _httpClient;
        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            var results = await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("api/Employees");
            return results;
        }
        public async Task<Employee> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Employee>($"api/Employees/{id}");
            return result;
        }

        public async Task<Employee> Update(int id, Employee employee)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Employees/{id}", employee);
            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Employee>(await response.Content.ReadAsStreamAsync());
            }
            else
            {
                throw new Exception("Gagal Update Data Employee");
            }
        }
        public async Task<Employee> Add(Employee obj)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/Employees", obj);
            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Employee>(await response.Content.ReadAsStreamAsync());
            }
            else
            {
                throw new Exception("gagal tambah data employee");
            }
        }
    }
}