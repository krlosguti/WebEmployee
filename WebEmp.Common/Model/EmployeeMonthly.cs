using WebEmp.Common.Model;

namespace WebEmp.DAL.Model
{
    public class EmployeeMonthly:Employee
    {
        public long monthlySalary { get; set; }
        public long salary => 12 * monthlySalary;
    }
}
