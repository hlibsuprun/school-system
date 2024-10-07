using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("BorrowedBooks", Schema = "SchoolSystem")]
    public class BorrowedBook
    {
        [Key]
        public Guid BorrowID { get; set; } = Guid.NewGuid();

        [Required]
        public Guid BookID { get; set; }

        [ForeignKey(nameof(BookID))]
        public Book Book { get; set; }

        [Required]
        public Guid StudentID { get; set; }

        [ForeignKey(nameof(StudentID))]
        public Student Student { get; set; }
    }
}
