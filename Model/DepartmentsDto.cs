using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Model
{
    public class DepartmentsDto
    {
        [Required]
        [StringLength(50)]
        public string DepartmentName { get; set; }
    }
}
