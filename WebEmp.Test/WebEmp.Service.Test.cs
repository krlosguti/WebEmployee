using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebEmp.DAL.Model;
using WebEmp.DAL.Repository;
using WebEmp.Service;
using Xunit;

namespace WebEmp.Test
{
    public class WebEmp
    {
        private Mock<IEmployeeRepository> _mockEmployeeRepository;

        public WebEmp()
        {
            _mockEmployeeRepository = new Mock<IEmployeeRepository>();
        }

        [Fact, Trait("Category", "Unit")]
        public async Task GetEmployeeFromFactoryMustCalculateSalaryAccordingWithEmployeeType()
        {
            //Arrange

            List<EmployeeDTO> TestEmployees = new List<EmployeeDTO>()
                {
                    new EmployeeDTO()
                    {
                        
                        id = 10,
                        name = "Employee one",
                        roleId = "1",
                        contractTypeName = "HourlySalaryEmployee",
                        hourlySalary = 8000
                    },
                    new EmployeeDTO()
                    {
                        id = 20,
                        name = "Employee two",
                        roleId = "1",
                        contractTypeName = "MonthlySalaryEmployee",
                        monthlySalary = 200000
                    }
                };

            decimal expectedAnualSalary1 = 11520000;
            decimal expectedAnualSalary2 = 24000000;

            //Act
            _mockEmployeeRepository.Setup(c => c.GetEmployees()).ReturnsAsync(() => TestEmployees);

            var service = new EmployeeService(_mockEmployeeRepository.Object);

            var result = await service.GetEmployees();

            //Assert

            Assert.AreEqual(result[0].yearSalary, expectedAnualSalary1);
            Assert.AreEqual(result[1].yearSalary, expectedAnualSalary2);
        }
    }
}