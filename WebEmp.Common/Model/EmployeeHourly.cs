namespace WebEmp.Common.Model
{
    public class EmployeeHourly : Employee
    {
        public long hourlySalary { get; set; }
        public override long value => hourlySalary;
        public override long yearSalary => 120 * 12 * hourlySalary;
    }
}
