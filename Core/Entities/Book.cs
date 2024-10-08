using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
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
