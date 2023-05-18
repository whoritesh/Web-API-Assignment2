using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Model
{
    public class EmployeesDto
    {
        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Range(21, 100)]
        public int Age { get; set; }

        public int DepartmentId { get; set; }

        public decimal Salary { get; set; }
    }
}
