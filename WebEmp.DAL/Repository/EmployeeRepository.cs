using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebEmp.DAL.Model;

namespace WebEmp.DAL.Repository
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private readonly string BaseAddress = "http://masglobaltestapi.azurewebsites.net/";
        static HttpClient client = new HttpClient();
        public async Task<List<EmployeeDTO>> GetEmployees()
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseAddress);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/Employees/");
                if (response.IsSuccessStatusCode)
                {
                    var EmployeeResponse = response.Content.ReadAsStringAsync().Result;
                    employees = JsonConvert.DeserializeObject<List<EmployeeDTO>>(EmployeeResponse);
                }
            }
            return employees;


        }

        public async Task<EmployeeDTO> GetEmployeeById(long id)
        {
            return GetEmployees().Result.FirstOrDefault(x => x.id == id);
        }
    }
}
