using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebEmp.Common.Model;
using WebEmp.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebEmp.UI.Controllers
{
    [Route("api/EmployeeAPI")]
    public class EmployeeAPIController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeAPIController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: api/<EmployeeAPIController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _employeeService.GetEmployees());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET api/<EmployeeAPIController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            try
            {                
                var result = (await _employeeService.GetEmployeeById(id));
                if(result != null)
                {
                    return Ok(result);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
