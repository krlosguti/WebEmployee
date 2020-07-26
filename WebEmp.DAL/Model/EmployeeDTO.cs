namespace WebEmp.DAL.Model
{
    public class EmployeeDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string contractTypeName { get; set; }
        public string roleId { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public long hourlySalary { get; set; }
        public long monthlySalary { get; set; }
    }
}
