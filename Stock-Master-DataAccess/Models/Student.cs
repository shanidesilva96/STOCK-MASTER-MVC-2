using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_DataAccess.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(15)]
        public string Roll { get; set; }

        public int SubjectId { get; set; }

        // Navigation property to represent the relationship
        public Subject Subject { get; set; }
    }
}
