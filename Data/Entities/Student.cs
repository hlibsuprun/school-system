using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Students", Schema = "SchoolSystem")]
    public class Student
    {
        [Key]
        public Guid StudentID { get; set; } = Guid.NewGuid();

        [Required]
        public Guid UserID { get; set; }

        [ForeignKey(nameof(UserID))]
        public User User { get; set; }

        public List<Grade> Grades { get; set; }
        public List<BorrowedBook> BorrowedBooks { get; set; }
    }
}
