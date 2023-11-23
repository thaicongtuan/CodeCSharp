using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTutorial.Model
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string StudentNumber { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }

        public  DateTime? DOB { get; set; }
        [StringLength(250)]
        public string POB{ get; set; }
         public long IdClassroom { get; set; }
        [ForeignKey("IdClassroom")]
        public virtual Classroom Classroom { get; set; }

    }
}
