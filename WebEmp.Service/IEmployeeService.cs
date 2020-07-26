using System.Collections.Generic;
using System.Threading.Tasks;
using WebEmp.Common.Model;

namespace WebEmp.Service
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();

        Task<Employee> GetEmployeeById(long id);
    }
}

