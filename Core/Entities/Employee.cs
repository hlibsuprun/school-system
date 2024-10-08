using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    [Table("Employees", Schema = "SchoolSystem")]
    public class Employee
    {
        [Key]
        public Guid EmployeeID { get; set; } = Guid.NewGuid();

        [Required]
        public Guid UserID { get; set; }

        [ForeignKey(nameof(UserID))]
        public User User { get; set; }
    }
}
