using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebEmp.Common.Model;
using WebEmp.DAL.Repository;

namespace WebEmp.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            var employeesDTO  = await _employeeRepository.GetEmployees();
            List<Employee> employees = new List<Employee>();
            foreach (var employeeDTO in employeesDTO)
            {
                Employee employee = EmployeeFactory.EmployeeFactory.GetEmployee(employeeDTO);
                employees.Add(employee);
            }
            return employees;
        }

        public async Task<Employee> GetEmployeeById(long id)
        {
            var employeeDTO = await _employeeRepository.GetEmployeeById(id);
            if (employeeDTO != null)
            {
                return EmployeeFactory.EmployeeFactory.GetEmployee(employeeDTO);
            }
            return null;
        }
    }
}
