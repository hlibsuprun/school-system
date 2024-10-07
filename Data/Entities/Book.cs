using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Books", Schema = "SchoolSystem")]
    public class Book
    {
        [Key]
        public Guid BookID { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        public List<BorrowedBook> BorrowedBooks { get; set; }
    }
}
