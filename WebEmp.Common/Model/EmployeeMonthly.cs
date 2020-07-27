using WebEmp.Common.Model;

namespace WebEmp.DAL.Model
{
    public class EmployeeMonthly:Employee
    {
        public long monthlySalary { get; set; }
        public override long value => monthlySalary;
        public override long yearSalary => 12 * monthlySalary;
    }
}
