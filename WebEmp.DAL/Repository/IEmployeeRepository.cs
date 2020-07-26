using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebEmp.DAL.Repository
{
    public interface IEmployeeRepository
    {
        /// <summary>
        /// asdfda
        /// </summary>
        /// <returns></returns>
        Task<List<Model.EmployeeDTO>> GetEmployees();

        /// <summary>
        /// sdf
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Model.EmployeeDTO> GetEmployeeById(long id);
    }
}
