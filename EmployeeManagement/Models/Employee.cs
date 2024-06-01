using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Position { get; set; }

        [Range(1, 100)]
        public int Age { get; set; }

        [StringLength(100)]
        public string Department { get; set; }
    }
}
