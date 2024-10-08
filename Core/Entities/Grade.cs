using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    [Table("Grades", Schema = "SchoolSystem")]
    public class Grade
    {
        [Key]
        public Guid GradeID { get; set; } = Guid.NewGuid();

        [Required]
        public Guid SubjectID { get; set; }

        [ForeignKey(nameof(SubjectID))]
        public Subject Subject { get; set; }

        [Required]
        public Guid StudentID { get; set; }

        [ForeignKey(nameof(StudentID))]
        public Student Student { get; set; }

        public double Grade1 { get; set; }
        public double Grade2 { get; set; }
    }
}
