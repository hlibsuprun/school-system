using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    [Table("Roles", Schema = "SchoolSystem")]
    public class Role
    {
        [Key]
        public Guid RoleID { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(50)]
        public string RoleName { get; set; }

        public List<User> Users { get; set; }
    }
}
