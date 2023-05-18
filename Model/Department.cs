using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Model
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string DepartmentName { get; set; }

        public List<Employee>? Employees { get; set; }
    }
}
