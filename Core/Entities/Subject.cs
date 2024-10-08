using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    [Table("Subjects", Schema = "SchoolSystem")]
    public class Subject
    {
        [Key]
        public Guid SubjectID { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(100)]
        public string SubjectName { get; set; }

        public List<Grade> Grades { get; set; }
    }
}
