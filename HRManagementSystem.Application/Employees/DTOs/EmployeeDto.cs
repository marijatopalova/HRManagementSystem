namespace HRManagementSystem.Application.Employees.DTOs
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public int DepartmentId { get; set; }
    }
}
