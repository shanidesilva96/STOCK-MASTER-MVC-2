using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Master_DataAccess.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        [Required]
        [StringLength(50)]
        public string SubjectName { get; set; }

        // Optional: If you want to define the inverse relationship
        public ICollection<Student> Students { get; set; }
    }
}
