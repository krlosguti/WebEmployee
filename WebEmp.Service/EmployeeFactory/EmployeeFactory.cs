using System;
using System.Collections.Generic;
using System.Text;
using WebEmp.Common.Model;
using WebEmp.DAL.Model;

namespace WebEmp.Service.EmployeeFactory
{
    public static class EmployeeFactory
    {
        public static Employee GetEmployee(EmployeeDTO employeeDTO)
        {
            Employee employee = null;
            switch (employeeDTO.contractTypeName)
            {
                case "HourlySalaryEmployee":
                        employee = new EmployeeHourly() 
                        { 
                            hourlySalary = employeeDTO.hourlySalary 
                        };
                        break;
                case "MonthlySalaryEmployee":
                    employee = new EmployeeMonthly()
                    {
                        monthlySalary = employeeDTO.monthlySalary
                    };
                    break;
            }

            employee.id = employeeDTO.id;
            employee.name = employeeDTO.name;
            employee.contractTypeName = employeeDTO.contractTypeName;
            employee.roleId = employeeDTO.roleId;
            employee.roleName = employeeDTO.roleName;
            employee.roleDescription = employeeDTO.roleDescription;

            return employee;
        }
    }
}
