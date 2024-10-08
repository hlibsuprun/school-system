﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    [Table("Users", Schema = "SchoolSystem")]
    public class User
    {
        [Key]
        public Guid UserID { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(60)]
        public string Password { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public Guid RoleID { get; set; }

        [ForeignKey(nameof(RoleID))]
        public Role Role { get; set; }

        public Student Student { get; set; }
        public Employee Employee { get; set; }
    }
}
