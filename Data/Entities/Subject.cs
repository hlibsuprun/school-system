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
