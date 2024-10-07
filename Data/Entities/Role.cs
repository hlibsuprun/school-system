using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
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
