using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
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

        public int Grade1 { get; set; }
        public int Grade2 { get; set; }
    }
}
